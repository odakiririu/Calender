using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.PlanItem;

namespace WindowsFormsApp1
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public PlanItem Job { get => job; set => job = value; }
        // event edit
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        // event delete 
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { Deleted -= value; }
        }
        public AJob(PlanItem job)
        {
            InitializeComponent();

            cbStatus.DataSource = PlanItem.ListStatus;

            this.Job = job;

            ShowInfo();
        }
        void ShowInfo()
        {
            txtJob.Text = Job.Job;
            nmFromHours.Value = Job.FromTime.X;
            nmFormMinutes.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinutes.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            chkDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }
        private void chkDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = chkDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Job = txtJob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFormMinutes.Value);
            Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMinutes.Value);
            Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];
            if (edited != null)
            {
                edited(this, new EventArgs());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
        }
    }
}

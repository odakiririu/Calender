using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Plan : Form
    {
        private DateTime date;
        private PlanData job;
        public DateTime Date { get => date; set => date = value; }
        public PlanData Job { get => job; set => job = value; }
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public Plan(DateTime date, PlanData job)
        {
            InitializeComponent();

            this.Date = date;
            this.Job = job;
            fPanel.Width = pnJob.Width;
            fPanel.Height = pnJob.Height;
            pnJob.Controls.Add(fPanel);
            dtpkPlan.Value = date;
        }

        void ShowJobByDay(DateTime date)
        {
            fPanel.Controls.Clear();
            if (job != null && Job.Job != null)
            {
                List<PlanItem> toDayJob = GetJobByDay(date);
                for (int i = 0; i < toDayJob.Count; i++)
                {
                    AddJob(toDayJob[i]);
                }
            }
        }

        private void AJob_Deleted(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem job = uc.Job;
            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        void AddJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Edited += AJob_Edited;
            aJob.Deleted += AJob_Deleted;
            fPanel.Controls.Add(aJob);
        }
        private void AJob_Edited(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        List<PlanItem> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        private void dtpkPlan_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDay((sender as DateTimePicker).Value);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkPlan.Value = dtpkPlan.Value.AddDays(1);
        }

        private void btnPrevioursDay_Click(object sender, EventArgs e)
        {
            dtpkPlan.Value = dtpkPlan.Value.AddDays(-1);
        }

        private void mnsAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dtpkPlan.Value};
            Job.Job.Add(item);
            AddJob(item);


        }

        private void nmsToDay_Click(object sender, EventArgs e)
        {
            dtpkPlan.Value = DateTime.Now;
        }
    }
}

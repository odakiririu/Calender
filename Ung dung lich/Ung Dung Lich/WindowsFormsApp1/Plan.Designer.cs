namespace WindowsFormsApp1
{
    partial class Plan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnJob = new System.Windows.Forms.Panel();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.nmsToDay = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpkPlan = new System.Windows.Forms.DateTimePicker();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnPrevioursDay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnJob);
            this.panel1.Location = new System.Drawing.Point(17, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 373);
            this.panel1.TabIndex = 0;
            // 
            // pnJob
            // 
            this.pnJob.Location = new System.Drawing.Point(4, 49);
            this.pnJob.Name = "pnJob";
            this.pnJob.Size = new System.Drawing.Size(1033, 315);
            this.pnJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAddJob,
            this.nmsToDay});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(1069, 28);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsAddJob
            // 
            this.mnsAddJob.Name = "mnsAddJob";
            this.mnsAddJob.Size = new System.Drawing.Size(94, 24);
            this.mnsAddJob.Text = "Thêm việc ";
            // 
            // nmsToDay
            // 
            this.nmsToDay.Name = "nmsToDay";
            this.nmsToDay.Size = new System.Drawing.Size(83, 24);
            this.nmsToDay.Text = "Hôm nay";
            // 
            // dtpkPlan
            // 
            this.dtpkPlan.Location = new System.Drawing.Point(374, 6);
            this.dtpkPlan.Name = "dtpkPlan";
            this.dtpkPlan.Size = new System.Drawing.Size(250, 22);
            this.dtpkPlan.TabIndex = 1;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(656, 1);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(104, 37);
            this.btnNextDay.TabIndex = 0;
            this.btnNextDay.Text = "Ngày sau";
            this.btnNextDay.UseVisualStyleBackColor = true;
            // 
            // btnPrevioursDay
            // 
            this.btnPrevioursDay.Location = new System.Drawing.Point(239, -1);
            this.btnPrevioursDay.Name = "btnPrevioursDay";
            this.btnPrevioursDay.Size = new System.Drawing.Size(103, 39);
            this.btnPrevioursDay.TabIndex = 2;
            this.btnPrevioursDay.Text = "Ngày trước";
            this.btnPrevioursDay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrevioursDay);
            this.panel2.Controls.Add(this.dtpkPlan);
            this.panel2.Controls.Add(this.btnNextDay);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 39);
            this.panel2.TabIndex = 1;
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMain;
            this.Name = "Plan";
            this.Text = "Kế hoạch";
            this.panel1.ResumeLayout(false);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkPlan;
        private System.Windows.Forms.Panel pnJob;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsAddJob;
        private System.Windows.Forms.ToolStripMenuItem nmsToDay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrevioursDay;
        private System.Windows.Forms.Button btnNextDay;
    }
}
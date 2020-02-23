namespace WindowsFormsApp1
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmToMinutes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nmFormMinutes = new System.Windows.Forms.NumericUpDown();
            this.nmToHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmFromHours = new System.Windows.Forms.NumericUpDown();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFormMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.chkDone);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(944, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(859, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 27);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(751, 6);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(102, 24);
            this.cbStatus.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmToMinutes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nmFormMinutes);
            this.panel2.Controls.Add(this.nmToHours);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmFromHours);
            this.panel2.Location = new System.Drawing.Point(423, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 23);
            this.panel2.TabIndex = 2;
            // 
            // nmToMinutes
            // 
            this.nmToMinutes.Location = new System.Drawing.Point(264, 1);
            this.nmToMinutes.Name = "nmToMinutes";
            this.nmToMinutes.Size = new System.Drawing.Size(57, 22);
            this.nmToMinutes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "từ";
            // 
            // nmFormMinutes
            // 
            this.nmFormMinutes.Location = new System.Drawing.Point(97, 0);
            this.nmFormMinutes.Name = "nmFormMinutes";
            this.nmFormMinutes.Size = new System.Drawing.Size(57, 22);
            this.nmFormMinutes.TabIndex = 1;
            // 
            // nmToHours
            // 
            this.nmToHours.Location = new System.Drawing.Point(196, 1);
            this.nmToHours.Name = "nmToHours";
            this.nmToHours.Size = new System.Drawing.Size(57, 22);
            this.nmToHours.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "đến";
            // 
            // nmFromHours
            // 
            this.nmFromHours.Location = new System.Drawing.Point(29, 0);
            this.nmFromHours.Name = "nmFromHours";
            this.nmFromHours.Size = new System.Drawing.Size(57, 22);
            this.nmFromHours.TabIndex = 0;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(37, 6);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(380, 22);
            this.txtJob.TabIndex = 1;
            // 
            // chkDone
            // 
            this.chkDone.AutoSize = true;
            this.chkDone.Location = new System.Drawing.Point(13, 9);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(18, 17);
            this.chkDone.TabIndex = 0;
            this.chkDone.UseVisualStyleBackColor = true;
            this.chkDone.CheckedChanged += new System.EventHandler(this.chkDone_CheckedChanged);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(1033, 42);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFormMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox chkDone;
        private System.Windows.Forms.NumericUpDown nmToMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmFormMinutes;
        private System.Windows.Forms.NumericUpDown nmToHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmFromHours;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}

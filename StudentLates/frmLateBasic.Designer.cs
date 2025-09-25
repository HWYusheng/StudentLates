namespace StudentLates
{
    partial class frmLateBasic
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDOL = new System.Windows.Forms.Label();
            this.lblMinsLate = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMinsLate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(210, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Late Form Basic";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(127, 61);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(127, 101);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(37, 13);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "Period";
            // 
            // lblDOL
            // 
            this.lblDOL.AutoSize = true;
            this.lblDOL.Location = new System.Drawing.Point(127, 136);
            this.lblDOL.Name = "lblDOL";
            this.lblDOL.Size = new System.Drawing.Size(66, 13);
            this.lblDOL.TabIndex = 3;
            this.lblDOL.Text = "Date of Late";
            // 
            // lblMinsLate
            // 
            this.lblMinsLate.AutoSize = true;
            this.lblMinsLate.Location = new System.Drawing.Point(127, 177);
            this.lblMinsLate.Name = "lblMinsLate";
            this.lblMinsLate.Size = new System.Drawing.Size(64, 13);
            this.lblMinsLate.TabIndex = 4;
            this.lblMinsLate.Text = "Minutes late";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(214, 61);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 5;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(214, 101);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 6;
            // 
            // txtMinsLate
            // 
            this.txtMinsLate.Location = new System.Drawing.Point(214, 177);
            this.txtMinsLate.Name = "txtMinsLate";
            this.txtMinsLate.Size = new System.Drawing.Size(100, 20);
            this.txtMinsLate.TabIndex = 7;
            // 
            // frmLateBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMinsLate);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblMinsLate);
            this.Controls.Add(this.lblDOL);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.labelTitle);
            this.Name = "frmLateBasic";
            this.Text = "frmLateBasic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDOL;
        private System.Windows.Forms.Label lblMinsLate;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtMinsLate;
    }
}
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDOL = new System.Windows.Forms.Label();
            this.lblMinsLate = new System.Windows.Forms.Label();
            this.txtMinsLate = new System.Windows.Forms.TextBox();
            this.dtpDOL = new System.Windows.Forms.DateTimePicker();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.btnSaveLate = new System.Windows.Forms.Button();
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
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(127, 61);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
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
            // txtMinsLate
            // 
            this.txtMinsLate.Location = new System.Drawing.Point(214, 177);
            this.txtMinsLate.Name = "txtMinsLate";
            this.txtMinsLate.Size = new System.Drawing.Size(114, 20);
            this.txtMinsLate.TabIndex = 7;
            // 
            // dtpDOL
            // 
            this.dtpDOL.Location = new System.Drawing.Point(214, 136);
            this.dtpDOL.Name = "dtpDOL";
            this.dtpDOL.Size = new System.Drawing.Size(114, 20);
            this.dtpDOL.TabIndex = 8;
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbPeriod.Location = new System.Drawing.Point(214, 98);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(114, 21);
            this.cmbPeriod.TabIndex = 9;
            this.cmbPeriod.SelectedIndexChanged += new System.EventHandler(this.cmbPeriod_SelectedIndexChanged);
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(214, 61);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(114, 21);
            this.cmbStudentID.TabIndex = 10;
            this.cmbStudentID.SelectedIndexChanged += new System.EventHandler(this.cmbStudentID_SelectedIndexChanged);
            // 
            // btnSaveLate
            // 
            this.btnSaveLate.Location = new System.Drawing.Point(214, 242);
            this.btnSaveLate.Name = "btnSaveLate";
            this.btnSaveLate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLate.TabIndex = 11;
            this.btnSaveLate.Text = "Save Late";
            this.btnSaveLate.UseVisualStyleBackColor = true;
            this.btnSaveLate.Click += new System.EventHandler(this.btnSaveLate_Click);
            // 
            // frmLateBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveLate);
            this.Controls.Add(this.cmbStudentID);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.dtpDOL);
            this.Controls.Add(this.txtMinsLate);
            this.Controls.Add(this.lblMinsLate);
            this.Controls.Add(this.lblDOL);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.labelTitle);
            this.Name = "frmLateBasic";
            this.Text = "frmLateBasic";
            this.Load += new System.EventHandler(this.frmLateBasic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDOL;
        private System.Windows.Forms.Label lblMinsLate;
        private System.Windows.Forms.TextBox txtMinsLate;
        private System.Windows.Forms.DateTimePicker dtpDOL;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.Button btnSaveLate;
    }
}
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
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.btnSaveLate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(210, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Late Form V3";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
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
            this.btnSaveLate.Location = new System.Drawing.Point(214, 114);
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
        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.Button btnSaveLate;
    }
}
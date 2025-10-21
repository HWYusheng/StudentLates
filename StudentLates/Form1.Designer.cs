namespace StudentLates
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstVStudents = new System.Windows.Forms.ListView();
            this.ColumnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnStudentLate = new System.Windows.Forms.Button();
            this.lstVLates = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageLateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Students";
            // 
            // lstVStudents
            // 
            this.lstVStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader0,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lstVStudents.FullRowSelect = true;
            this.lstVStudents.HideSelection = false;
            this.lstVStudents.Location = new System.Drawing.Point(16, 42);
            this.lstVStudents.Name = "lstVStudents";
            this.lstVStudents.Size = new System.Drawing.Size(310, 188);
            this.lstVStudents.TabIndex = 1;
            this.lstVStudents.UseCompatibleStateImageBehavior = false;
            this.lstVStudents.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader0
            // 
            this.ColumnHeader0.Text = "StudentID";
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "First Name";
            this.ColumnHeader1.Width = 73;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Last Name";
            this.ColumnHeader2.Width = 69;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "DOB";
            this.ColumnHeader3.Width = 103;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Student Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudentLate
            // 
            this.btnStudentLate.Location = new System.Drawing.Point(148, 248);
            this.btnStudentLate.Name = "btnStudentLate";
            this.btnStudentLate.Size = new System.Drawing.Size(81, 23);
            this.btnStudentLate.TabIndex = 3;
            this.btnStudentLate.Text = "Student Late";
            this.btnStudentLate.UseVisualStyleBackColor = true;
            this.btnStudentLate.Click += new System.EventHandler(this.btnStudentLate_Click);
            // 
            // lstVLates
            // 
            this.lstVLates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstVLates.FullRowSelect = true;
            this.lstVLates.HideSelection = false;
            this.lstVLates.Location = new System.Drawing.Point(352, 42);
            this.lstVLates.Name = "lstVLates";
            this.lstVLates.Size = new System.Drawing.Size(369, 188);
            this.lstVLates.TabIndex = 4;
            this.lstVLates.UseCompatibleStateImageBehavior = false;
            this.lstVLates.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "StudentID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Student Name";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date of Late";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mins Late";
            this.columnHeader7.Width = 61;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Period";
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(409, 248);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(121, 21);
            this.cmbStudentID.TabIndex = 7;
            this.cmbStudentID.SelectedIndexChanged += new System.EventHandler(this.cmbStudentID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "Stats";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageLateToolStripMenuItem});
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // averageLateToolStripMenuItem
            // 
            this.averageLateToolStripMenuItem.Name = "averageLateToolStripMenuItem";
            this.averageLateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.averageLateToolStripMenuItem.Text = "Average Late";
            this.averageLateToolStripMenuItem.Click += new System.EventHandler(this.averageLateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStudentID);
            this.Controls.Add(this.lstVLates);
            this.Controls.Add(this.btnStudentLate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstVStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstVStudents;
        private System.Windows.Forms.ColumnHeader ColumnHeader0;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStudentLate;
        private System.Windows.Forms.ListView lstVLates;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageLateToolStripMenuItem;
    }
}


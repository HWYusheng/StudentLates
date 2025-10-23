namespace StudentLates
{
    partial class FrmReport
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.cbCountOfLate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(415, 12);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(101, 23);
            this.btnPrintReport.TabIndex = 2;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // cbCountOfLate
            // 
            this.cbCountOfLate.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCountOfLate.AutoSize = true;
            this.cbCountOfLate.Location = new System.Drawing.Point(552, 13);
            this.cbCountOfLate.Name = "cbCountOfLate";
            this.cbCountOfLate.Size = new System.Drawing.Size(83, 23);
            this.cbCountOfLate.TabIndex = 3;
            this.cbCountOfLate.Text = "Count Of Late";
            this.cbCountOfLate.UseVisualStyleBackColor = true;
            this.cbCountOfLate.CheckedChanged += new System.EventHandler(this.cbCountOfLate_CheckedChanged);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCountOfLate);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.webBrowser1);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.CheckBox cbCountOfLate;
    }
}
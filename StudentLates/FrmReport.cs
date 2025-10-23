using StudentLates.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLates
{
    public partial class FrmReport : Form
    {
        LateRepositary lateRepositary;
        List<LatesWithStudentNames> lates;
        List<LatesWithStudentNames> latesCount;
        public FrmReport()
        {
            InitializeComponent();
            lateRepositary = new LateRepositary();
            lates = lateRepositary.GetLatesWithStudentNames();
            latesCount = lateRepositary.GetLatesWithStudentNamesCount();
            GenerateReport(lates);
            
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

        }

        private void GenerateReport(List<LatesWithStudentNames> lates)
        {
            string html = "<html><head><style>" +
                            "body { font-family: Arial; }" +
                            "table { width: 100%; border-collapse: collapse; }" +
                            "th, td { border: 1px solid black; padding: 8px; }" +
                            "</style></head><body>";
            html += "<h1>All Lates Report</h1>";
            html += "<table><tr><th>Student ID</th><th>Name</th><th>Date of Late</th><th>Minutes Late</th></tr>";
            foreach (var item in lates)
            {
                
                html += $"<tr><td>{item.StudentID}</td><td>{item.FirstName + " " + item.LastName}</td><td>{item.DateOfLate.ToShortDateString()}</td><td>{item.MinsLate}</td></tr>";
            }
            html += "</htlm>";
            webBrowser1.DocumentText = html;
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void CountOfLateReport(List<LatesWithStudentNames> latesCount)
        {
            string html = "<html><head><style>" +
                            "body { font-family: Arial; }" +
                            "table { width: 100%; border-collapse: collapse; }" +
                            "th, td { border: 1px solid black; padding: 8px; }" +
                            "</style></head><body>";
            html += "<h1>Lates Count Report</h1>";
            html += "<table><tr><th>Student ID</th><th>Name</th><th>Count of Late</th><tr>";
            foreach (var item in latesCount)
            {
                html += $"<tr><td>{item.StudentID}</td><td>{item.FirstName + " " + item.LastName}</td><td>{item.countOfLate}</td></tr>";
            }
            html += "</htlm>";
            webBrowser1.DocumentText = html;
        }

        private void cbCountOfLate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCountOfLate.Checked)
            {
                CountOfLateReport(latesCount);
            }
            else
            {
                GenerateReport(lates);
            }
        }
    }
}

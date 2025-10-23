using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLates;

namespace StudentLates
{
    public partial class Form1 : Form
    {
        private StudentRepositary studentRepositary; // declares studentRepositary though not instantiated yet
        private LateRepositary lateRepositary;
        public Form1()
        {
            InitializeComponent();
            studentRepositary = new StudentRepositary(); // instantiate the studentRepositary object
            lateRepositary = new LateRepositary();
        }
       
        public void DisplayStudents() // needs to be public so can be accessed from FrmStudent
        {
            var students = studentRepositary.GetStudents();
            lstVStudents.Items.Clear(); // clear the ListView before adding new items
            foreach (var student in students)
            {
                ListViewItem item = new ListViewItem(student.StudentID.ToString());
                item.SubItems.Add(student.FirstName); // subitems are used to add additional columns in ListView
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.StudentDOB.ToShortDateString());
                lstVStudents.Items.Add(item);
            }
        }
        public void DisplayLates() // needs to be public so can be accessed from FrmStudent
        {
            var latesWithStudentName = lateRepositary.GetLatesWithStudentNames();
            lstVLates.Items.Clear(); // clear the ListView before adding new items
            foreach (var late in latesWithStudentName)
            {
                ListViewItem item = new ListViewItem(late.StudentID.ToString());
                item.SubItems.Add(late.FirstName + " " + late.LastName);
                item.SubItems.Add(late.DateOfLate.ToShortDateString()); // subitems are used to add additional columns in ListView
                item.SubItems.Add(late.MinsLate.ToString());
                item.SubItems.Add(late.Period.ToString());
                lstVLates.Items.Add(item);
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            DisplayStudents(); // 

            var students = studentRepositary.GetStudents();
            Student blank = new Student();
            blank.FirstName = "[Show";
            blank.LastName = "all]";
            blank.StudentID = -1;
            students.Insert(0, blank);
            cmbStudentID.DisplayMember = "FullName";
            cmbStudentID.ValueMember = "StudentID";
            cmbStudentID.DataSource = students;
            DisplayLates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudent studentForm = new frmStudent();
            studentForm.Show();
        }

        private void btnStudentLate_Click(object sender, EventArgs e)
        {
            frmLateBasic lateForm = new frmLateBasic();
            lateForm.Show();
        }

        private void cmbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStudentID.SelectedValue != null)
            {
                if (Convert.ToInt32(cmbStudentID.SelectedValue) == -1)
                {
                    DisplayLates();
                }
                else
                {
                    int studentID = Convert.ToInt32(cmbStudentID.SelectedValue);
                    var latesWithStudentName = lateRepositary.GetLatesWithStudentNames(studentID);
                    lstVLates.Items.Clear(); // clear the ListView before adding new items
                    foreach (var late in latesWithStudentName)
                    {
                        ListViewItem item = new ListViewItem(late.StudentID.ToString());
                        item.SubItems.Add(late.FirstName + " " + late.LastName);
                        item.SubItems.Add(late.DateOfLate.ToShortDateString()); // subitems are used to add additional columns in ListView
                        item.SubItems.Add(late.MinsLate.ToString());
                        item.SubItems.Add(late.Period.ToString());
                        lstVLates.Items.Add(item);
                    }
                }

            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        private void averageLateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double aveLate = lateRepositary.GetAverageLate();
            MessageBox.Show($"The average late mins for all students is {aveLate:N2}");
        }

        private void btnFrmReport_Click(object sender, EventArgs e)
        {
            FrmReport lateReport = new FrmReport();
            lateReport.Show();
        }
    }
}

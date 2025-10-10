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
            var lates = lateRepositary.GetLates();
            var student = new Student();
            lstVStudents.Items.Clear(); // clear the ListView before adding new items
            foreach (var late in lates)
            {
                ListViewItem item = new ListViewItem(late.StudentID.ToString());
                item.SubItems.Add(late.DateOfLate.ToShortDateString()); // subitems are used to add additional columns in ListView
                item.SubItems.Add(late.MinsLate.ToString());
                item.SubItems.Add(late.Period.ToString());
                lstVStudents.Items.Add(item);
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            DisplayStudents(); // 
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
    }
}

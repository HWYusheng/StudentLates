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
    public partial class frmStudent : Form
    {


        StudentRepositary studentRepositary;
        public frmStudent()
        {
            InitializeComponent();
            studentRepositary = new StudentRepositary();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            var students = studentRepositary.GetStudents(); // var used but could be List<Student> for clarity
            cmbStudentID.DisplayMember = "FullName";
            cmbStudentID.ValueMember = "StudentID";
            cmbStudentID.DataSource = students;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            studentRepositary.AddStudent(new Student { FirstName = txtfirstName.Text, LastName = txtLastName.Text, StudentDOB = dtpDob.Value });
            UpdateForms();
        }
        private void UpdateForms()
        {
            frmStudent_Load(null, null);
            (Application.OpenForms["Form1"] as Form1).DisplayStudents(); // calls DisplayStudents method from Form1 (Form1 must be open)
        }

        private void cmbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = studentRepositary.GetFilteredStudent(Convert.ToInt32(cmbStudentID.SelectedValue));
            if (student != null)
            {
                txtfirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                dtpDob.Value = student.StudentDOB;
            }
            else
            {
                MessageBox.Show("Student not found.");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                StudentID = Convert.ToInt32(cmbStudentID.SelectedValue),
                FirstName = txtfirstName.Text,
                LastName = txtLastName.Text,
                StudentDOB = dtpDob.Value
            };
            studentRepositary.UpdateStudent(student);
            UpdateForms();
        }
    }
}

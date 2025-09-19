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

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            studentRepositary.AddStudent(new Student { FirstName = txtfirstName.Text, LastName = txtLastName.Text, StudentDOB = dtpDob.Value });
            UpdateForms();
        }
        private void UpdateForms()
        {
            (Application.OpenForms["Form1"] as Form1).DisplayStudents(); // calls DisplayStudents method from Form1 (Form1 must be open)
        }
    }
}

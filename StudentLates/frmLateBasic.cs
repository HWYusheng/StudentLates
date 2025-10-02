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
    public partial class frmLateBasic : Form
    {
        StudentRepositary studentRepositary;
        LateRepositary lateRepositary;
        public frmLateBasic()
        {
            InitializeComponent();
            studentRepositary = new StudentRepositary();
        }

        private void frmLateBasic_Load(object sender, EventArgs e)
        {
            var students = studentRepositary.GetStudents(); // var used but could be List<Student> for clarity
            cmbStudentID.DisplayMember = "FullName";
            cmbStudentID.ValueMember = "StudentID";
            cmbStudentID.DataSource = students;
        }

        private void cmbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveLate_Click(object sender, EventArgs e)
        {
            lateRepositary.AddLate(new Late {
                StudentID = Convert.ToInt32(cmbStudentID.ValueMember),
                Period = Convert.ToInt32(cmbPeriod.SelectedValue),
                DateOfLate = dtpDOL.Value,
                MinsLate = Convert.ToInt32(txtMinsLate.Text)
            });
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

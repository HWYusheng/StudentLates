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
            lateRepositary = new LateRepositary();
            
        }

        private void frmLateBasic_Load(object sender, EventArgs e)
        {
            var students = studentRepositary.GetStudents(); // var used but could be List<Student> for clarity
            cmbStudentID.DisplayMember = "FullName";
            cmbStudentID.ValueMember = "StudentID";
            cmbStudentID.DataSource = students;
            AddButtons();
        }

        private void cmbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveLate_Click(object sender, EventArgs e)
        {
            try
            {
                lateRepositary.AddLate(new Late
                {
                    StudentID = Convert.ToInt32(cmbStudentID.SelectedValue),
                });
                
            }
            catch (Exception)
            {
                MessageBox.Show("Late student wasn't added.");
            }

            
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = studentRepositary.GetFilteredStudent(Convert.ToInt32(cmbStudentID.SelectedValue));
        }

        private void dtpDOL_ValueChanged(object sender, EventArgs e)
        {

        }
        private void AddButtons()
        {
            int count = 0;
            var students = studentRepositary.GetStudents();
            foreach (var item in students)
            {
                Button btn = new Button();
                btn.BackColor = Color.Lime;
                btn.ForeColor = Color.Black;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                btn.Tag = item.StudentID; // Store the StudentID in the Tag property for later use
                btn.Text = item.FullName;
                btn.Name = "btn_ " + count;
                count++;
                btn.Click += Btn_Click; // type btn.Click += <tab><tab> to auto generate the event handler
                flpStudents.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button buttonPressed = (Button)sender;
            try
            {
                lateRepositary.AddLate(new Late
                {
                    StudentID = Convert.ToInt32(buttonPressed.Tag),
                });

            }
            catch (Exception)
            {
                MessageBox.Show("Late student wasn't added.");
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void flpStudents_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

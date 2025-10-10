using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            AddUCs();
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
        private void AddUCs()
        {
            int count = 0;
            var students = studentRepositary.GetStudents();
            foreach (var item in students)
            {
                UCLateStudent _UCLateStudent = new UCLateStudent();
                _UCLateStudent.BackColor = Color.Lime;
                _UCLateStudent.ForeColor = Color.Black;
                _UCLateStudent.Size = new Size(100, 90);
                _UCLateStudent.Visible = true;
                _UCLateStudent.Tag = item.StudentID; // Store the StudentID in the Tag property for later use
                _UCLateStudent.StudentName = item.FullName;
                _UCLateStudent.NumberOfLates = lateRepositary.GetNumberOfLates(item.StudentID);
                _UCLateStudent.Name = "UCStudentLate_" + count;
                count++;
                _UCLateStudent.Click += _UCLateStudent_Click; // type btn.Click += <tab><tab> to auto generate the event handler
                _UCLateStudent.Update();
                flpStudents.Controls.Add(_UCLateStudent);
            }
        }

        private int GetNumberOfLates(int studentID)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\sLatesDB.accdb";
            string sql = $"SELECT COUNT(*) FROM tblLate WHERE StudentID = {studentID}";
            int NumsOfLates;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                NumsOfLates = (int)cmd.ExecuteScalar();
            }
            return NumsOfLates;
        }

        private void _UCLateStudent_Click(object sender, EventArgs e)
        {
            UCLateStudent buttonPressed = (UCLateStudent)sender;
            try
            {
                lateRepositary.AddLate(new Late
                {
                    StudentID = Convert.ToInt32(buttonPressed.Tag),
                });
                //buttonPressed.NumberOfLates = GetNumberOfLates(buttonPressed.StudentID);
                buttonPressed.NumberOfLates++;
                buttonPressed.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Late student wasn't added.");
            }
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

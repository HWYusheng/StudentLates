using StudentLates.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLates
{
    internal class LateRepositary
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\sLatesDB.accdb";
        public List<LatesWithStudentNames> GetLatesWithStudentNames()
        {
            List<LatesWithStudentNames> studentsLate = new List<LatesWithStudentNames>();
            string sql = "SELECT tblStudent.studentID, tblStudent.firstName, tblStudent.lastName, tblLate.period, tblLate.dateOfLate, tblLate.minsLate" 
                           + "" + " FROM (tblLate INNER JOIN tblStudent ON tblLate.StudentID = tblStudent.StudentID)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LatesWithStudentNames studentLate = new LatesWithStudentNames
                        {
                            StudentID = reader.GetInt32(0), // the first column is LateID
                            FirstName = reader.GetString(1), // the second column is StudentID
                            LastName = reader.GetString(2),
                            Period = reader.GetInt32(3), // the third column is Period
                            DateOfLate = reader.GetDateTime(4), // the fourth column is DateOfLate
                            MinsLate = reader.GetInt32(5) // the fourth column is MinsLate
                        };
                        studentsLate.Add(studentLate);
                        
                    }
                }
            }
            return studentsLate;
        }
        public List<LatesWithStudentNames> GetLatesWithStudentNamesCount()
        {
            List<LatesWithStudentNames> studentsLate = new List<LatesWithStudentNames>();
            string sql = "SELECT s.studentID, s.firstName, s.lastName, COUNT(*) AS [Number Of Lates] FROM (tblStudent s INNER JOIN tblLate l ON s.studentID = l.studentID) GROUP BY s.studentID, s.firstName, s.lastName";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LatesWithStudentNames studentLate = new LatesWithStudentNames
                        {
                            StudentID = reader.GetInt32(0), // the first column is LateID
                            FirstName = reader.GetString(1), // the second column is StudentID
                            LastName = reader.GetString(2),
                            countOfLate = reader.GetInt32(3)
                        };
                        studentsLate.Add(studentLate);

                    }
                }
            }
            return studentsLate;
        }
        public int GetNumberOfLates(int studentID)
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
        public void AddLate(Late late)
        {
            string sql = "INSERT INTO tblLate (StudentID, Period, DateOfLate, minsLate) VALUES (?, ?, ?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))

            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                int per = 0, minsLate = 0;
                GetPeriodAndMinsLate(ref per, ref minsLate);
                cmd.Parameters.AddWithValue("@StudentID", late.StudentID);
                cmd.Parameters.AddWithValue("@Period", per);
                cmd.Parameters.AddWithValue("@DateOfLate", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@MinsLate", minsLate);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Student ID {late.StudentID} is late {minsLate} for period {per}.");

            }
        }
        public void GetPeriodAndMinsLate(ref int period, ref int minsLate)
        {
            int minsFrom9am = 0;
            DateTime nineOclockDate = DateTime.Today; // the time at midnight this morning
            nineOclockDate = nineOclockDate.AddHours(9); // the date and time at 9:00am
            DateTime DateOfLate = DateTime.Now;
            minsFrom9am = Convert.ToInt32((DateTime.Now - nineOclockDate).TotalMinutes);
            if (minsFrom9am > 0 && minsFrom9am < 89)
            {
                period = 1;
                minsLate = minsFrom9am;
            }
            else if (minsFrom9am > 110 && minsFrom9am < 199)
            {
                period = 2;
                minsLate = minsFrom9am - 110;
            }
            else if (minsFrom9am > 250 && minsFrom9am < 339)
            {
                period = 3;
                minsLate = minsFrom9am - 250;
            }
            else if (minsFrom9am > 350 && minsFrom9am < 439)
            {
                period = 4;
                minsLate = minsFrom9am - 350;
            }
        }

        public double GetAverageLate()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\sLatesDB.accdb";
            string sql = $"SELECT AVG(minsLate) FROM tblLate";
            double NumsOfLates;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                NumsOfLates = (double)cmd.ExecuteScalar();
            }
            return NumsOfLates;
        }

        internal IEnumerable<LatesWithStudentNames> GetLatesWithStudentNames(int studentID)
        {
            List<LatesWithStudentNames> studentsLate = new List<LatesWithStudentNames>();
            string sql = "SELECT tblStudent.studentID, tblStudent.firstName, tblStudent.lastName, tblLate.period, tblLate.dateOfLate, tblLate.minsLate"
                           + "" + " FROM (tblLate INNER JOIN tblStudent ON tblLate.StudentID = tblStudent.StudentID)" + "" + "WHERE tblStudent.StudentID = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@studentid", studentID);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LatesWithStudentNames studentLate = new LatesWithStudentNames
                        {
                            StudentID = reader.GetInt32(0), // the first column is LateID
                            FirstName = reader.GetString(1), // the second column is StudentID
                            LastName = reader.GetString(2),
                            Period = reader.GetInt32(3), // the third column is Period
                            DateOfLate = reader.GetDateTime(4), // the fourth column is DateOfLate
                            MinsLate = reader.GetInt32(5) // the fourth column is MinsLate
                        };
                        studentsLate.Add(studentLate);

                    }
                }
            }
            return studentsLate;
        }
    }
}
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
        public List<Late> GetLates()
        {
            List<Late> studentsLate = new List<Late>();
            string sql = "SELECT * FROM tblLate";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Late studentLate = new Late
                        {
                            LateID = reader.GetInt32(0), // the first column is LateID
                            StudentID = reader.GetInt32(1), // the second column is StudentID
                            Period = reader.GetInt32(2), // the third column is Period
                            DateOfLate = reader.GetDateTime(3), // the fourth column is DateOfLate
                            MinsLate = reader.GetInt32(4) // the fourth column is MinsLate
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

    }
}
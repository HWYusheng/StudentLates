using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLates
{
    internal class LateRepositary
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\sLatesDB.accdb";
        public List<Late> GetLate()
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

        public void AddLate(Late student)
        {
            string sql = "INSERT INTO tblLate (StudentID, Period, DateOfLate, MinsLate) VALUES (?, ?, ?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                cmd.Parameters.AddWithValue("@Period", student.Period);
                cmd.Parameters.AddWithValue("@DateOfLate", student.DateOfLate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@MinsLate", student.MinsLate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void GetPeriodAndMinsLate(ref int period, ref int minsLate)
        {
            int minsFrom9am = 0;
            DateTime nineOclockDate = DateTime.Today; // the time at midnight this morning
            nineOclockDate = nineOclockDate.AddHours(9); // the date and time at 9:00am
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
        }
    }
}
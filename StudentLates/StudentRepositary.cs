using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace StudentLates
{
    internal class StudentRepositary
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\sLatesDB.accdb";
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            string sql = "SELECT * FROM tblStudent";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            StudentID = reader.GetInt32(0), // the first column is StudentID
                            FirstName = reader.GetString(1), // the second column is FirstName
                            LastName = reader.GetString(2), // the third column is LastName
                            StudentDOB = reader.GetDateTime(3) // the fourth column is StudentDOB
                        };
                        students.Add(student);
                    }
                }
            }
            return students;
        }
        public void AddStudent(Student student)
        {
            string sql = "INSERT INTO tblStudent (FirstName, LastName, StudentDOB) VALUES (?, ?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@StudentDOB", student.StudentDOB.ToString("yyyy-MM-dd"));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}

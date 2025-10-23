using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLates.Model
{
    public class LatesWithStudentNames
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfLate { get; set; }
        public int Period { get; set; }
        public int MinsLate { get; set; }
        public int countOfLate { get; set; }
    }
}

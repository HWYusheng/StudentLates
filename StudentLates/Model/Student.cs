using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLates
{
    public class Student
    {
        public int StudentID { get; set; } // property for Student ID
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StudentDOB { get; set; }
        public string FullName // used for combobox display, this is readonly because there is no set
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}

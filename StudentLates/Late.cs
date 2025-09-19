using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLates
{
    public class Late
    {
        public int LateID { get; set; }
        public int StudentID { get; set; }
        public DateTime DateOfLate { get; set; }
        public int Period { get; set; }
        public int MinsLate { get; set; }
    }
}

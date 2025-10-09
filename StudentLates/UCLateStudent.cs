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
    public partial class UCLateStudent : UserControl
    {
        public int NumberOfLates { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public UCLateStudent()
        {
            InitializeComponent();
        }

        private void UCLateStudent_Load(object sender, EventArgs e)
        {
            if (NumberOfLates >= 2)
            {
                this.BackColor = Color.Red;
            }
            lblName.Text = StudentName;
            //lblNumLates.Text = NumberOfLates.ToString();
            lblNumLates.Text = "kjdshafkjhds";

        }

        public void UpdateControl()
        {

            UCLateStudent_Load(null, null);
        }

        private void lblNumLates_Click(object sender, EventArgs e)
        {

        }
    }
}

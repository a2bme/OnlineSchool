using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSchool
{
    public partial class Main : Form
    {
        private Student student;
        public Main(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // what to do here
        }
    }
}

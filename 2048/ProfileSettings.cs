using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048;

namespace _2048
{
    public partial class Profile_Form : Form
    {
        public Profile_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2048.Game4.NameProfile = textBox1.Text;
            this.Close();
        }
    }
}

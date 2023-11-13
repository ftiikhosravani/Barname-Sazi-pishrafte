using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        customer f1 = new customer();
        custlist f2 = new custlist();
        product f3 = new product();
        prolist f4 = new prolist();

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f4.Show();
        }
    }
}

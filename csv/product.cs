using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csv
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string price = textBox2.Text;
            string comma = ",";
            string lines = name + comma + price+"\n";
            File.AppendAllText("pari.csv", lines);
        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        private void product_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}

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
    public partial class custlist : Form
    {
        public custlist()
        {
            InitializeComponent();
        }

        private void custlist_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("customer.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }

        private void custlist_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}

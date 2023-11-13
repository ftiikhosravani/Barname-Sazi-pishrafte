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
    public partial class prolist : Form
    {
        public prolist()
        {
            InitializeComponent();
        }

        private void prolist_Load(object sender, EventArgs e)
        {
            string[] array = File.ReadAllLines("pari.csv");
            for(int i = 0; i<array.Length; i++)
            {
                listBox1.Items.Add(array[i]);
            }
        }

        private void prolist_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}

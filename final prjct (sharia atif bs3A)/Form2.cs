using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace final_prjct
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addevnt ae = new addevnt();
            ae.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            evntinfo ein = new evntinfo();
            ein.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newcust nc = new newcust();
            nc.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            evntfees ef = new evntfees();
            ef.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            schduleevnt se = new schduleevnt();
            se.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            custrecd cr = new custrecd();
            cr.Show();
        }
    }
}

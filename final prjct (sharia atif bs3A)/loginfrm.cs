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
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="sharia" && this.textBox2.Text == "sharia")
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
           
            }
        }

    }
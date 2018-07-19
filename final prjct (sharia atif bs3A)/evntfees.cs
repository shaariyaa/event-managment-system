using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final_prjct
{
    public partial class evntfees : Form
    {
        conection_form conn = new conection_form(); 
        public evntfees()
        {
            InitializeComponent();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("insert into payment(customer_code,event_type,other_charges,initial_payment,total_charges,balance)values(@customer_code,@event_type,@other_charges,@initial_charges,@balance)", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@customer_code", textbox1.Text);
            cmd.Parameters.AddWithValue("@event_type", textbox2.Text);
            cmd.Parameters.AddWithValue("@other_charges", textbox3.Text);
            cmd.Parameters.AddWithValue("@initial_payment", textbox4.Text);
            cmd.Parameters.AddWithValue("@total_charges", textbox5.Text);
            cmd.Parameters.AddWithValue("@balance", textbox6.Text);

            MessageBox.Show("data has been inserted");
            conn.sqlConnection1.Close();


        }
    }
}

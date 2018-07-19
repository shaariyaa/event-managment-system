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
    public partial class custrecd : Form
    {
        conection_form conn = new conection_form();
        public custrecd()
        {
            InitializeComponent();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
           conn.sqlConnection1.Open();
           SqlCommand cmd = new SqlCommand("insert into customer(customer_code,full_name)values(@customer_code,@full_name)", conn.sqlConnection1);

           cmd.Parameters.AddWithValue("@customer_code", txtCode.Text);
           cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
           MessageBox.Show("data has been inserted");
     

            conn.sqlConnection1.Close();
        }
    }
}
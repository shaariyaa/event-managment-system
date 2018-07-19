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
    public partial class schduleevnt : Form
    {
        conection_form conn = new conection_form();
        public schduleevnt()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void schduleevnt_Load(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("payment recieved");
        }

        private void txtCostFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox2.Text == "1")
            {
                string[] customer_Ful_lName = { "shadi", "barat", "valima" };
                combox1.Items.Clear();


            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("insert into schedule(customer_code,sutomer_FullName,event_type,Venue,cost_fess)values(@customer_code,@customer_fullName,@event_type,@Venue,cost_fees)", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@customer_code", combox1.Text);
            cmd.Parameters.AddWithValue("@customer_FullName", textbox1.Text);
            cmd.Parameters.AddWithValue("@event_type", combox2.Text);
            cmd.Parameters.AddWithValue("@Venue", textbox2.Text);
            cmd.Parameters.AddWithValue("@cost_fees", textbox2.Text);
        
            MessageBox.Show("data has been inserted");
            conn.sqlConnection1.Close();

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("update add_event set customer_code='" + combox1.Text + "',customer_FullName='" + textbox1.Text + "'event_type '"+combox2+"',Venue '"+textbox2+"',cost_fees '"+textbox3+"' where schedule=@schedule", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@customer_code", combox1.Text);
            cmd.Parameters.AddWithValue("@customer_FullName", textbox1.Text);
            cmd.Parameters.AddWithValue("@event_type", combox2.Text);
            cmd.Parameters.AddWithValue("@Venue", textbox2.Text);
            cmd.Parameters.AddWithValue("@cost_fees", textbox2.Text);
        

            conn.sqlConnection1.Close(); 

        }

        private void combox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox1.Text == "1")
            {
                string[] customer_Ful_lName = { "sharia", "laiba", "maida" };
                combox2.Items.Clear();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textbox1.Clear();
            this.textbox2.Clear();
            this.textbox3.Clear();
           
        }
    }

}

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
    public partial class newcust : Form
    {
        conection_form conn = new conection_form();
       public newcust()
       {

            InitializeComponent();
        }
        
         
          
        private void newcust_Load(object sender, EventArgs e)
        {
           
           
       }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("insert into customer(customer_code,last_name,gender,state_origin,Resident_Address,Phone1,Phone_2,email_add,natinality)values(@customer_code,@last_name,gender,@state_origin,@Resident_Address,@Phone1,@mobile_no,@email_add,@natinality)", conn.sqlConnection1);

            cmd.Parameters.AddWithValue("@customer_code", textbox1.Text);
            cmd.Parameters.AddWithValue("@last_name", textbox2.Text);
            cmd.Parameters.AddWithValue("@other_name", textbox3.Text);
            cmd.Parameters.AddWithValue("@Resident_Address", textbox4.Text);
            cmd.Parameters.AddWithValue("@gender", combox1.Text);
            cmd.Parameters.AddWithValue("@state_origin", combox2.Text);
            cmd.Parameters.AddWithValue("@mobile_no", textbox5.Text);
            cmd.Parameters.AddWithValue("@nationality", textbox7.Text);
            cmd.Parameters.AddWithValue("@email_add", txtEmail.Text);
            MessageBox.Show("data has been inserted");


            conn.sqlConnection1.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textbox1.Clear();
            this.textbox2.Clear();
            this.textbox3.Clear();
            this.textbox4.Clear();
            this.textbox5.Clear();
            this.textbox6.Clear();
            this.textbox7.Clear();
            this.txtEmail.Clear();
            MessageBox.Show("deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("update add_event set customer_code='"+textbox1.Text+"',last_name ='"+textbox2.Text+"',Other_Name = '"+textbox3.Text+"', gender ='"+combox1.Text+"', state_origin = '"+combox2.Text+"'   ,Residential_Address= '"+textbox4.Text+"',Phone_1= '"+textbox5.Text+"',Phone_2='"+textbox6.Text+"',Email_Address='"+txtEmail+"',Nationality= '"+textbox7.Text+"' where customer_id=@customer_id",conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@customer_code", textbox1.Text);
            cmd.Parameters.AddWithValue("@last_name", textbox2.Text);
            cmd.Parameters.AddWithValue("@other_name", textbox3.Text);
            cmd.Parameters.AddWithValue("@Resident_Address", textbox4.Text);
            cmd.Parameters.AddWithValue("@gender", combox1.Text);
            cmd.Parameters.AddWithValue("@state_origin", combox2.Text);
            cmd.Parameters.AddWithValue("@mobile_no", textbox5.Text);
            cmd.Parameters.AddWithValue("@nationality", textbox7.Text);
            cmd.Parameters.AddWithValue("@email_add", txtEmail.Text);
            MessageBox.Show("data has been updated");


            conn.sqlConnection1.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
        f2.Show();
        }
    }
}

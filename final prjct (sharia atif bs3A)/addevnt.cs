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
    public partial class addevnt : Form
    { conection_form conn=new conection_form();

        public addevnt()
        {
            InitializeComponent();
        }

        private void addevnt_Load(object sender, EventArgs e)
        {

        }

        private void txtEvent_code_TextChanged(object sender, EventArgs e)
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
            SqlCommand cmd=new SqlCommand("insert into add_event(event_code,event_name)values(@event_code,@event_name)",conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@event_code",textbox1.Text);
            cmd.Parameters.AddWithValue("@event_name",textbox2.Text);
            MessageBox.Show("data has been inserted");
            conn.sqlConnection1.Close();



               
        }

        private void txtEven_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("update add_event set event_code='" + textbox1.Text + "',event_name='" + textbox2.Text + "' where event_id=@event_id", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@event_code", textbox1.Text);
            cmd.Parameters.AddWithValue("@event_name", textbox2.Text);
            
            conn.sqlConnection1.Close(); 
        }
           

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textbox1.Clear();
            this.textbox2.Clear();
            MessageBox.Show("it has been deleted");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {
        
        }
    }
}

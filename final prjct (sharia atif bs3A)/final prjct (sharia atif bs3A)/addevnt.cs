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
    {
        conection_form cf = new conection_form();
        public addevnt()
        {
            InitializeComponent();
        }

        private void addevnt_Load(object sender, EventArgs e)
        {

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=shaaria\\SQLExpress;Initial Catalog=akueb(hms);Integrated Security=True");
            con.Open();
            try 
            {


                string str = " insert into event values('" + textbox1.Text + "','" + textbox2.Text + "','" + "'); "; 

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(pat_id) from patient ;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(" Record addSuccessfully. ");
                    textbox1.Text = "";
                    textbox2.Text = "";
                   
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }
    }
}

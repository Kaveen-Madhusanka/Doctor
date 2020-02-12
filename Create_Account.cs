using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doctor
{
    public partial class Create_Account : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\dispensary.mdf;Integrated Security=True;Connect Timeout=30");
        
        public Create_Account()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCname.TextLength == 0)
                {
                    MessageBox.Show("check  user name", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   /* if (txtCpassword.Text == txtComPassword.Text)
                    {
                       // SqlCommand com = new SqlCommand("insert into login values('" + txtCname.Text + "','" + txtCpassword.Text + "')", con);
                       
                        SqlCommand com = new SqlCommand("Update login set password='" + txtCpassword.Text + "' where usarName='" + txtCname.Text + "'", con);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Password changed", "Account Status");
                        Login log = new Login();
                        log.Show(); this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password Confamation Failed");
                    }*/
                    String dbpasss="";
                    SqlCommand cmd = new SqlCommand("select password from login where (usarName='" + txtCname.Text + "')", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        dbpasss = rdr.GetString(0);
                        //MessageBox.Show(dbpasss);
                    }
                    else
                    {
                        MessageBox.Show("check Current  user name","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    if (txtconform.Text == txtComPassword.Text)
                    {

                        if (txtCpassword.Text == dbpasss)
                        {
                            SqlCommand com = new SqlCommand("Update login set password='" + txtComPassword.Text + "' where usarName='" + txtCname.Text + "'", con);
                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Password changed", "Account Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login log = new Login();
                            log.Show(); this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Wrong current  password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("conform password not mached","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
                    }

                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Check Current user name and paasword ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*finally
            {
                con.Close();
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show(); this.Hide();
        }
    }
}

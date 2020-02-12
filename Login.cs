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
    public partial class Login : Form
    {
        //Connection col = new Connection();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\dispensary.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*SqlCommand cmd = new SqlCommand("insert into login values('"+txtUserName.Text+"','"+txtPasword.Text+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted");*/

            /*if (txtUserName.Text == "kaveen" && txtPasword.Text == "123")
            {
                MessageBox.Show("login ok", "CAPTION ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                new Medicine().Show();
                this.Hide();
                
            }
            else
             {
                MessageBox.Show("login fail", "CAPTION ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
             }*/
            try
            {
                string usname, password, dbname, dbpass;
                //usname = txtUserName.ToString();
                //password = txtPasword.ToString();
                // dbname="select usarName from login  "
                SqlCommand cmd = new SqlCommand("select password from login where (usarName='" + txtUserName.Text + "')", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    dbpass = rdr.GetString(0);
                    //MessageBox.Show(dbpass);
                    if (txtPasword.Text == dbpass)
                    {
                       // MessageBox.Show("login ok", "CAPTION ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        new Medicine().Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("check password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("check password and user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                con.Close();  
            }
           

            
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Create_Account ca = new Create_Account();
            ca.Show(); this.Hide();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.TextLength == 0)
            {
                MessageBox.Show("check user name","Blank Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void txtPasword_Leave(object sender, EventArgs e)
        {
            if (txtPasword.TextLength == 0)
            {
                MessageBox.Show("Check user Password", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}

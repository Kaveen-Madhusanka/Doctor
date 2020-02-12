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
    public partial class income : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\dispensary.mdf;Integrated Security=True;Connect Timeout=30");
        public income()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int am = Convert.ToInt32(txtamount.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO income(id,amount,date) VALUES ('" + txtId.Text + "','" + am + "','" + txtdate.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Details Inserted.....!"," successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

            txtamount.Text = "";
            txtId.Text = "";
            txtdate.Text = "";

        }

        private void btndaly_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                //double a;
                //String qry = " SELECT SUM(amount)  FROM   income WHERE date >= '2018-01-01' AND date   <= '2018-01-30' ";
                SqlDataAdapter adpt = new SqlDataAdapter("select * from income WHERE date >= '" + txtfdate.Text + "' AND date   <= '" + txttdate.Text + "'", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                lbltotal.Text = sum.ToString();
                //SqlCommand cmd = new SqlCommand(qry, con);
                //String result = Convert.ToString(cmd.ExecuteScalar());
                //lbltotal.Text = result;

                con.Close();
            
            }
            catch (Exception ex)
            {

                MessageBox.Show("Enter correct details", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Medicine md = new Medicine();
            md.Show();
            this.Close();
        }
    }
}

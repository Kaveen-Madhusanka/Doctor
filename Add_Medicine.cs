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
    public partial class Add_Medicine : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\dispensary.mdf;Integrated Security=True;Connect Timeout=30");
        

        int qnt;
        double t_price;
        private int p=1;
        public Add_Medicine()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               // t_price = Convert.ToDouble(txtAprice.Text) * Convert.ToInt32(txtAqnt.Text);


                SqlCommand com = new SqlCommand("select Quntity from MdStock where Medicine_Name='" + txtAmedicine.Text + "'", con);
                con.Open();
                qnt = Convert.ToInt32(com.ExecuteScalar());
                con.Close();

                if (qnt > Convert.ToInt32(txtAqnt.Text))
                {
                    qnt = qnt - Convert.ToInt32(txtAqnt.Text);
                    MessageBox.Show("Medicine issued", "Stock Status",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not enough Quantity in hand", "Stock Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                SqlCommand cmd = new SqlCommand("update MdStock set quntity=" + qnt + " where Medicine_Name='" + txtAmedicine.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

               /* SqlCommand comm = new SqlCommand("insert into IMedicines values (" + p + ",'" + txtAmedicine.Text + "'," + txtAqnt.Text + "," + t_price + ")", con);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();*/

               

                txtAmedicine.Text = "";
                txtAqnt.Text = "";
                txtAprice.Text = "";

                SqlDataAdapter adr = new SqlDataAdapter("select * from MdStock ", con);
                DataTable dt = new DataTable();
                con.Open();
                adr.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;
            }

            catch (Exception ex )
            {
                MessageBox.Show(ex+" Connection Error", "your data base is dismis");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
               /* SqlCommand com = new SqlCommand("delete from IMedicines where pid=1", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                Medicine md = new Medicine();
                md.Show();
                this.Close();*/
            }
            catch (Exception )
            {
                MessageBox.Show("Connection Error", "your data base is dismis");
            }
        }

        private void Add_Medicine_Load(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter adr = new SqlDataAdapter("select * from MdStock ", con);
                DataTable dt = new DataTable();
                con.Open();
                adr.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;
            }
            catch (Exception )
            {
                MessageBox.Show("Connection Error", "your data base is dismis");
            }
            /*SqlDataAdapter adr = new SqlDataAdapter("select medicine,Quantity,price from IMedicines ", con);
            DataTable dt = new DataTable();
            con.Open();
            adr.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           Medicine md = new Medicine();
            md.Show();
            this.Close();
        }
    }
}

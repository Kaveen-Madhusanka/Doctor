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
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\dispensary.mdf;Integrated Security=True;Connect Timeout=30");
        public Bill()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Mdstock VALUES ('" +txtMeID.Text + "','" +txtMeNem.Text+ "','" +txtQnty.Text+ "','" +txtMnfDt.Text+ "','" +txtExDat.Text+ "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Inserted.....!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtMeID.Clear();
                txtMeNem.Clear();
                txtQnty.Clear();
                txtMnfDt.Clear();
                txtExDat.Clear();
              
             
                    //con.Open();
                   /* SqlDataAdapter adp = new SqlDataAdapter("select * from Mdstock", con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;*/
                dis();
             
               
                   
               
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CAN'T INSERT", "error CHECK MEDICINE ID OR ENTER CORRECT DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Mdstock WHERE (MedicineID ='" + txtMeID.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Deleted.....!","", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*SqlDataAdapter adp = new SqlDataAdapter("select * from Mdstock", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;*/
                dis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error CHECK PATEINT ID", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  Mdstock SET MedicineID = '" + txtMeID.Text + "',Medicine_Name ='" + txtMeNem.Text + "',Quntity ='" + txtQnty.Text + "',Manufacture_Date='" + txtMnfDt.Text + "',Expire_Date='" + txtExDat.Text + "' WHERE (MedicineID ='" +txtMeID.Text+ "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Updated.....!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

               /* SqlDataAdapter adp = new SqlDataAdapter("select * from Mdstock", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;*/
                dis();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CAN'T UPDATE", "error CHECK PATEINT ID OR ENTER CORRECT DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }
        void dis()
        {
                SqlDataAdapter adpt = new SqlDataAdapter("select * from MdStock", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            try
            {
               /* con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from Mdstock", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;*/
                dis();
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection error. please contact developer","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
           


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new Medicine().Show();
            this.Hide();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtMeID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtMeNem.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtQnty.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtMnfDt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtExDat.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}

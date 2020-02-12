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
using System.Configuration;

namespace Doctor
{
    public partial class Medicine : Form
    {
        //static string connectionString = ConfigurationManager.AppSettings["DBCon"];
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\dispensary.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection con = new SqlConnection(connectionString);       
       
        public Medicine()
        {
            InitializeComponent();
            SetColours();
        }
      

        private void SetColours()
        {
           
            string colorName=null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Name from font where id=1",con);
                colorName = Convert.ToString(cmd.ExecuteScalar());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CAN'T UPDATE", "error in DB connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            Color color = Color.FromName(colorName);
            label1.ForeColor = color;
            label2.ForeColor = color;
            label3.ForeColor = color;
            label4.ForeColor = color;
            label5.ForeColor = color;
            label6.ForeColor = color;
            label7.ForeColor = color;
            label8.ForeColor = color;
            label9.ForeColor = color;
            label10.ForeColor = color;
            rbtnMale.ForeColor = color;
            rbtnFemale.ForeColor = color;
            label11.ForeColor = color;
            label12.ForeColor = color;
            label13.ForeColor = color;
            label14.ForeColor = color;
            label15.ForeColor = color;
            lbln.ForeColor = color;

           
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                
               
                txtPID.Clear();
                txtName.Clear();
                txtCase.Clear();
                txtMedic.Clear();
                txtDiscription.Clear();
                txtBout.Clear();
                txtAge.Clear();
                txtSearch.Clear();
                txtFamily.Clear();
                txtAds.Clear();
                txtTP.Clear();
               
                //txtDate.Clear();
            }
            catch(Exception)
            {
            }
           

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
        }

        void display()
        {
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select * from details", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();

                }
            }
            catch (Exception)
            {
 
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                erpBlanck.Clear();
                display();

            }
            catch (Exception)
            {
 
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                cmbg.Text = "";
                //cmbg.SelectedIndex.Equals(String.Empty);
                txtPID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtAge.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtDate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtCase.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtMedic.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtDiscription.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtBout.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                cmbg.SelectedText = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtFamily.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                txtTP.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtAds.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM details WHERE (pid ='" + txtPID.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Deleted.....!");
                txtPID.Clear();
                txtName.Clear();
                txtCase.Clear();
                txtMedic.Clear();
                txtDiscription.Clear();
                txtBout.Clear();
                txtAge.Clear();
                txtSearch.Clear();
                txtFamily.Clear();
                txtAds.Clear();
                txtTP.Clear();
                display();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String g = cmbg.Text.ToString();
               // MessageBox.Show(g);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  details SET name ='" + txtName.Text + "',age ='" + txtAge.Text + "',Ail='" + txtCase.Text + "',Medicine='" + txtMedic.Text + "',discription='" + txtDiscription.Text + "',gender='"+g+"',family='"+txtFamily.Text+"',TP='"+txtTP.Text+"',Address='"+txtAds.Text+"' WHERE (pid ='" + txtPID.Text + "')", con);
                cmd.ExecuteNonQuery();
                 MessageBox.Show("Details Updated.....!");
                 txtPID.Clear();
                 txtName.Clear();
                 txtCase.Clear();
                 txtMedic.Clear();
                 txtDiscription.Clear();
                 txtBout.Clear();
                 txtAge.Clear();
                 txtSearch.Clear();
                 txtFamily.Clear();
                 txtAds.Clear();
                 txtTP.Clear();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                SqlDataAdapter adpt = new SqlDataAdapter("select * from details where pid= '"+ txtSearch.Text+"' ", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
               /* SqlDataAdapter adpt = new SqlDataAdapter("select * from details WHERE pid = " + txtSearch.Text, con);
                DataTable dt = new DataTable();
                con.Open();
                adpt.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    //dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();*/


                }
            } 

            catch(Exception ex)
            {
                 MessageBox.Show(ex.Message + "CAN'T SERACH", "error CHECK PATEINT ID ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            try
            {
                dateTimePicker1.Value = System.DateTime.Now;
                txtDate.Text = System.DateTime.Now.ToShortDateString();
                display();
                String split = (String)dataGridView1[0, dataGridView1.RowCount - 1].Value;
                // MessageBox.Show(split);
                int ind = Convert.ToInt16(split);
                ind++;
                lbln.Text = ind.ToString();
               
               /* String y = "s";

                SqlCommand com = new SqlCommand("select idno from id1 where t='" + y + "'", con);
                con.Open();
                lbln.Text = Convert.ToString(com.ExecuteScalar());
                con.Close();*/
            }
            catch(Exception)
            {

            }
           

           
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update font set Name='" + colorDialog1 .Color.Name+ "' where id=1",con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Font Updated.....!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show( "CAN'T UPDATE. contact developer", "Error in DB connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                try
                {

                    //SetColours();
                    label1.ForeColor = colorDialog1.Color;
                    label2.ForeColor = colorDialog1.Color;
                    label3.ForeColor = colorDialog1.Color;
                    label4.ForeColor = colorDialog1.Color;
                    label5.ForeColor = colorDialog1.Color;
                    label6.ForeColor = colorDialog1.Color;
                    label7.ForeColor = colorDialog1.Color;
                    label8.ForeColor = colorDialog1.Color;
                    label9.ForeColor = colorDialog1.Color;
                    label10.ForeColor = colorDialog1.Color;
                    rbtnFemale.ForeColor = colorDialog1.Color;
                    rbtnMale.ForeColor = colorDialog1.Color;
                    label12.ForeColor = colorDialog1.Color;
                    label13.ForeColor = colorDialog1.Color;
                    label14.ForeColor = colorDialog1.Color;
                    label15.ForeColor = colorDialog1.Color;
                    lbln.ForeColor = colorDialog1.Color;
                    label11.ForeColor = colorDialog1.Color;
                    lbln.ForeColor = colorDialog1.Color;
                   

                }
                catch(Exception)
                {}
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    label1.Font = fontDialog1.Font;
                    label2.Font = fontDialog1.Font;
                    label3.Font = fontDialog1.Font;
                    label4.Font = fontDialog1.Font;
                    label5.Font = fontDialog1.Font;
                    label6.Font = fontDialog1.Font;
                    label7.Font = fontDialog1.Font;
                    label8.Font = fontDialog1.Font;
                    label9.Font = fontDialog1.Font;
                    label10.Font = fontDialog1.Font;
                    rbtnMale.Font = fontDialog1.Font;
                    rbtnFemale.Font = fontDialog1.Font;
                    label12.Font = fontDialog1.Font;
                    label13.Font = fontDialog1.Font;
                    label14.Font = fontDialog1.Font;
                    label11.Font = fontDialog1.Font;
                    label15.Font = fontDialog1.Font;
                    lbln.Font = fontDialog1.Font;
                }
                
           
            
            }
            catch(Exception)
            {}
        }

        private void txtCase_TextChanged(object sender, EventArgs e)
        {
            txtCase.SelectionStart = txtCase.Text.Length;
            txtCase.ScrollToCaret();
            txtCase.Refresh();
        }

        private void txtMedic_TextChanged(object sender, EventArgs e)
        {
            txtMedic.SelectionStart = txtMedic.Text.Length;
            txtMedic.ScrollToCaret();
            txtMedic.Refresh();
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Instructions().Show();
           // this.Hide();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            txtDate.Text = System.DateTime.Now.ToString();
           // int idno;
            try
            {
               
                /*string gender="";
                if(rbtnMale.Checked==true)
                {
                    gender = "Male";
                   // MessageBox.Show(gender);
                }
                else if(rbtnFemale.Checked==true)
                {
                    gender = "Female";
                   // MessageBox.Show(gender);
                }*/
                
                   
                    String g=null;
                    if (cmbg.SelectedIndex > -1)
                    {
                        g = cmbg.SelectedItem.ToString();
                    }
                    else
                    {
                        String s = cmbg.Text;
                       // MessageBox.Show(s);
                        g = s;
                    }
                    
                    
                    
                    


              
                
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO details(pid,name,age,Date,Ail,Medicine,discription,bout,gender,family,TP,Address) VALUES ('" + txtPID.Text + "','" + txtName.Text + "','" + txtAge.Text + "','" + txtDate.Text + "','" + txtCase.Text + "','" + txtMedic.Text + "','" + txtDiscription.Text + "','" + txtBout.Text + "','" + g + "','"+txtFamily.Text+"','"+txtTP.Text+"','"+txtAds.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Inserted.....!");
                String z="s";
                display();

               /* SqlCommand com = new SqlCommand("select idno from id1 where t='" + z + "'", con);         
                idno = Convert.ToUInt16(com.ExecuteScalar());

                idno++;
                SqlCommand c = new SqlCommand("UPDATE id1 SET idno='"+idno+"', t='"+z+"'",con);
                c.ExecuteNonQuery();*/
               // MessageBox.Show("insert id");

               // SqlCommand co = new SqlCommand("select idno from id1 where t='" + z + "'", con); 
                
               // lbln.Text = Convert.ToString(co.ExecuteScalar());
                String split = (String)dataGridView1[0, dataGridView1.RowCount - 1].Value;
                //MessageBox.Show(split);
                int ind =Convert.ToInt16(split);
                ind++;
                lbln.Text = ind.ToString();
                txtPID.Clear();
                txtName.Clear();
                txtCase.Clear();
                txtMedic.Clear();
                txtDiscription.Clear();
                txtBout.Clear();
                txtAge.Clear();
                txtSearch.Clear();
                txtFamily.Clear();
                txtAds.Clear();
                txtTP.Clear();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("CAN'T INSERT.  CHECK PATEINT ID OR ENTER CORRECT DATA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new contact().Show();
        }

        private void txtPID_Leave(object sender, EventArgs e)
        {
            if (txtPID.TextLength == 0)
            {
                erpBlanck.SetError(txtPID,"can not blank");
               // erpBlanck.Clear();
            }
        }

        private void txtBout_Leave(object sender, EventArgs e)
        {
            if (txtBout.TextLength == 0)
            {

                MessageBox.Show("check bout", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBout.Text.All(char.IsDigit) != true)
            {
                MessageBox.Show("check bout", "Only Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {
            erpBlanck.Clear();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0)
            {
                MessageBox.Show("check user name", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bill().Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void issueMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Add_Medicine am = new Add_Medicine();
            am.Show();
            this.Close();
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.TextLength == 0)
            {
                MessageBox.Show("check  Age", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAge.Text.All(char.IsDigit) != true)
            {
                MessageBox.Show("check  Age", "only number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCase_Leave(object sender, EventArgs e)
        {
            if (txtCase.Text.All(char.IsLetter) != true)
            {
               // MessageBox.Show("check  Case ", "only Letter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            /*if (txtSearch.TextLength == 0)
            {
                MessageBox.Show("check  ID in search", "Blanck Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About am = new About();
            am.Show();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                SqlDataAdapter adpt = new SqlDataAdapter("select * from details where family like '%" + txtSearch.Text + "%' ", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                    /* SqlDataAdapter adpt = new SqlDataAdapter("select * from details WHERE pid = " + txtSearch.Text, con);
                     DataTable dt = new DataTable();
                     con.Open();
                     adpt.Fill(dt);
                     dataGridView1.Rows.Clear();
                     foreach (DataRow item in dt.Rows)
                     {
                         int n = dataGridView1.Rows.Add();
                         dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                         dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                         dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                         dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                         dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                         dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                         dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                         dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                         //dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();*/


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CAN'T SERACH", "error CHECK PATEINT ID ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {

        }

        private void btnSerhname_Click(object sender, EventArgs e)
        {

            try
            {


                SqlDataAdapter adpt = new SqlDataAdapter("select * from details where name like '%" + txtSearch.Text + "%' ", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                    


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CAN'T SERACH", "error CHECK PATEINT ID ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            income n1 = new income();
            n1.Show();
            this.Close();

        }
        }
    }



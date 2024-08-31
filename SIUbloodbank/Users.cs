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

namespace SIUbloodbank
{
    public partial class Users : Form
    {
        Myconnection objcon = new Myconnection();//creating object
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        string Blockstatus;
        int userid;
        void Clear()
        {
            txtFullname.Clear();
            txtUsername.Clear();
            txtpassword.Clear();
            txtcomfirm.Clear();
            txtphone.Clear();
            rbtnno.Checked = true;
            rbtnyes.Checked = false;
            txtUsername.Enabled = true;
            btnaction.Text = "save";
            txtFullname.Focus();
            dtpdor.Text = System.DateTime.Today.ToShortDateString();
        }

        void Fillusersdatagridview()
        {
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand("select * from Users", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


        public Users()
        {
            InitializeComponent();
        }
        private void Btnaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullname.Text == "")
                {
                    MessageBox.Show("enter your fullname", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullname.Focus();
                    return;
                }
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("enter your username ", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
                if (txtpassword.Text == "")
                {
                    MessageBox.Show("enter your password", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Focus();
                    return;
                }
                if (txtcomfirm.Text == "")
                {
                    MessageBox.Show("comfirm your password", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcomfirm.Focus();
                    return;
                }
                if (txtphone.Text == "")
                {
                    MessageBox.Show("enter your number", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtphone.Focus();
                    return;
                }
                float  password,comfirm,phone,fullname;
                fullname = 0;
                password = 0;
                comfirm = 0;
                phone = 0;
                if((float.TryParse(txtFullname.Text, out fullname)))
                {
                    MessageBox.Show(" numeric values are not allowed", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullname.Focus();
                    txtFullname.Clear();
                    return;
                }
                if (!(float.TryParse(txtpassword.Text, out password)))
                {
                    MessageBox.Show("enter only numeric values", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Focus();
                    txtpassword.Clear();
                    return;
                }
                if (!(float.TryParse(txtcomfirm.Text, out comfirm)))
                {
                    MessageBox.Show("enter only numeric values", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcomfirm.Focus();
                    txtcomfirm.Clear();
                    return;
                }
                if (!(float.TryParse(txtphone.Text, out phone)))
                {
                    MessageBox.Show("enter only numeric values", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtphone.Focus();
                    txtphone.Clear();
                    return;
                }
                if (txtpassword.Text!=txtcomfirm.Text)
                {
                    lblpass.Text = "passwords are not matched";
                    lblpass.Visible = true;
                    txtpassword.Clear();
                    txtpassword.Focus();
                    txtcomfirm.Clear();
                    lblpass.ForeColor = Color.Red;
                    return;
                }
                if (rbtnyes.Checked == true)
                {
                    Blockstatus = rbtnyes.Text;
                }
                else if (rbtnno.Checked == true)
                {
                    Blockstatus = rbtnno.Text;
                }
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                if(btnaction.Text=="save")
                {
                    cmd = new SqlCommand("select Username from Users where username='" + txtUsername.Text + "'",con);
                    dr = cmd.ExecuteReader();
                    if(dr.Read()==true)
                    {
                        MessageBox.Show("this username has already been used..", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtUsername.Focus();
                        dr.Close();
                        return;
                    }
                    dr.Close();
                    cmd = new SqlCommand("select ISNULL(max(userid),0)+1 from users", con);
                    int id = Convert.ToInt32( cmd.ExecuteScalar().ToString());
                    cmd = new SqlCommand("insert into users values('" + id + "','" + txtFullname.Text + "','" + txtUsername.Text + "','" + txtpassword.Text + "','" + txtphone.Text + "','" + Blockstatus + "','" + dtpdor.Text + "')", con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("your data has been saved successfully", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Fillusersdatagridview();
                    }
                    Clear();
                }
                else if(btnaction.Text=="Update")
                {
                    cmd = new SqlCommand("Update Users set fullname='" + txtFullname.Text + "',password='" + txtpassword.Text + "',phone='" + txtphone.Text + "',isblocked='" + Blockstatus + "',dor='" + dtpdor.Text + "' where Userid='"+userid+"'", con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("your data has been Updated successfully", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Fillusersdatagridview();
                    }
                    Clear();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                con = objcon.GetConnection();
                Fillusersdatagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userid = Convert.ToInt32( dgvUsers.CurrentRow.Cells[0].Value.ToString());
                txtFullname.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                txtUsername.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
                txtpassword.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
                txtcomfirm.Text = txtpassword.Text;
                txtphone.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
                Blockstatus= dgvUsers.CurrentRow.Cells[5].Value.ToString();
                if(Blockstatus=="Yes")
                {
                    rbtnyes.Checked = true;
                }
                else if(Blockstatus=="No")
                {
                    rbtnno.Checked = true;
                }
                dtpdor.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
                txtUsername.Enabled = false;
                btnaction.Text = "Update";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}

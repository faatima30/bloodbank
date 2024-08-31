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
    public partial class Login : Form
    {
        Myconnection objcon = new Myconnection();//creating object
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                con = objcon.GetConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
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
                float password;
                password = 0;
                if (!(float.TryParse(txtpassword.Text, out password)))
                {
                    MessageBox.Show("enter only numeric values", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Focus();
                    txtpassword.Clear();
                    return;
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand("select * from Users where Username='" + txtUsername.Text + "' and Password='"+txtpassword.Text+"'", con);
                dr = cmd.ExecuteReader();
                if(dr.Read()==true)
                {
                    string Blockstatus = dr.GetValue(5).ToString();
                    dr.Close();
                    //checking if block or not
                    if (Blockstatus == "Yes")
                    {
                        MessageBox.Show("your Account has been blocked ,contact Admin ", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtpassword.Clear();
                        txtUsername.Focus();
                    }
                    else
                    {
                        Mainform objmain = new Mainform();
                        objmain.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("invalid username or password ", " SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    txtUsername.Clear();
                    txtpassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}

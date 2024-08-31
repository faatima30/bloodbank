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
    public partial class Donors : Form
    {
        Myconnection objcon = new Myconnection();//creating object
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string Gender;
        string bloodtype;
        SqlDataAdapter da = new SqlDataAdapter();
        int donorid;
        void Clear()
        {
            txtdonorname.Clear();
            txtaddress.Clear();
            txtphone.Clear();
            rbtnfemale.Checked = true;
            rbtnmale.Checked = false;
            btnaction.Text = "save";
            txtdonorname.Focus();
            dtp.Text = System.DateTime.Today.ToShortDateString();
            cmbbloodtype.SelectedIndex = 0;
        }

        void Filldonorsdatagridview()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand("select * from Donors", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdonors.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        
        public Donors()
        {
            InitializeComponent();
        }

        private void Btnaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdonorname.Text == "")
                {
                    MessageBox.Show("enter your name", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdonorname.Focus();
                    return;
                }
                if (txtaddress.Text == "")
                {
                    MessageBox.Show("enter your address ", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtaddress.Focus();
                    return;
                }
                if (txtphone.Text == "")
                {
                    MessageBox.Show("enter your number", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtphone.Focus();
                    return;
                }
                if (cmbbloodtype.SelectedIndex == 0)
                {
                    MessageBox.Show("please select a bloodtype", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbbloodtype.Focus();
                    return;
                }

                float donorname, address, phone;
                donorname = 0;
                address = 0;
                phone = 0;
                if ((float.TryParse(txtdonorname.Text, out donorname)))
                {
                    MessageBox.Show(" numeric values are not allowed", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdonorname.Focus();
                    txtdonorname.Clear();
                    return;
                }
                if ((float.TryParse(txtaddress.Text, out address)))
                {
                    MessageBox.Show("numeric values are not allowed", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtaddress.Focus();
                    txtaddress.Clear();
                    return;
                }
                if (!(float.TryParse(txtphone.Text, out phone)))
                {
                    MessageBox.Show("enter only numeric values", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtphone.Focus();
                    txtphone.Clear();
                    return;
                }
                bloodtype = cmbbloodtype.Text;

                if (bloodtype == "O+")
                {
                    bloodtype = cmbbloodtype.Text;

                }
                else if (bloodtype == "A+")
                {
                    bloodtype = cmbbloodtype.Text;
                }
                else if (bloodtype == "B+")
                {
                    bloodtype = cmbbloodtype.Text;
                }
                else if (bloodtype == "AB+")
                {
                    bloodtype = cmbbloodtype.Text;
                }
                else if (bloodtype == "O-")
                {
                    bloodtype = cmbbloodtype.Text;
                }
                else if (bloodtype == "A-")
                {
                    bloodtype = cmbbloodtype.Text;
                }
                else if (bloodtype == "B-")
                {
                    bloodtype = cmbbloodtype.Text;
                }
                else if (bloodtype == "AB-")
                {
                    bloodtype = cmbbloodtype.Text;
                }

                if (rbtnfemale.Checked == true)
                {
                    Gender = rbtnfemale.Text;
                }
                else if (rbtnmale.Checked == true)
                {
                    Gender = rbtnmale.Text;
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (btnaction.Text == "save")
                {
                    cmd = new SqlCommand("select ISNULL(max(donorid),0)+1 from Donors", con);
                    int Donorid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    cmd = new SqlCommand("insert into Donors values('" + Donorid + "','" + txtdonorname.Text + "','" + txtphone.Text + "','" + txtaddress.Text + "','" + Gender + "','" + cmbbloodtype.Text + "','" + dtp.Text + "')", con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("your data has been saved successfully", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Filldonorsdatagridview();
                    }
                    Clear();
                }
                else if (btnaction.Text == "Update")
                {
                    cmd = new SqlCommand("Update Donors set Donorname='" + txtdonorname.Text + "',phone='" + txtphone.Text + "',address='" + txtaddress.Text + "',bloodtype='" + bloodtype+ "',Gender='" + Gender + "',dor='" + dtp.Text + "' where Donorid='" + donorid + "'", con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("your data has been Updated successfully", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Filldonorsdatagridview();
                    }
                    Clear();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Donors_Load(object sender, EventArgs e)
        {
            try
            {
                cmbbloodtype.SelectedIndex = 0;
                con = objcon.GetConnection();
                Filldonorsdatagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Dgvdonors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                donorid = Convert.ToInt32(dgvdonors.CurrentRow.Cells[0].Value.ToString());
                txtdonorname.Text = dgvdonors.CurrentRow.Cells[1].Value.ToString();
                txtphone.Text = dgvdonors.CurrentRow.Cells[2].Value.ToString();
                txtaddress.Text = dgvdonors.CurrentRow.Cells[3].Value.ToString();
                Gender = dgvdonors.CurrentRow.Cells[4].Value.ToString();
                if (Gender == "Female")
                {
                    rbtnfemale.Checked = true;
                }
                else if (Gender == "Male")
                {
                    rbtnmale.Checked = true;
                }
                cmbbloodtype.Text= dgvdonors.CurrentRow.Cells[5].Value.ToString();
                dtp.Text = dgvdonors.CurrentRow.Cells[6].Value.ToString();
                btnaction.Text = "Update";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Cmbbloodtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

       
    }

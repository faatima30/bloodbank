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
    public partial class Blooddonor : Form
    {
        Myconnection objcon = new Myconnection();//creating object
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        int Blooddonorid;
        
        void Clear()
        {
            cmbdonornames.SelectedIndex=0;
            txtbloodtype.Clear();
            txtQuantity.Clear();
            btnaction.Text = "save";
            cmbdonornames.Focus();
            dtpdonordate.Text = System.DateTime.Today.ToShortDateString();
        }
        void  Fillblooddonordatagridview()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd = new SqlCommand("select donorbloodid,blooddonor.donorid,donorname,Blooddonor.Bloodtype,quantity,donordate from donors join Blooddonor on Donors.DonorID = Blooddonor.Donorid", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvblooddonor.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        
    void Filldonornames()

        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd = new SqlCommand("select 0 as donorid,'---select donorname---' as donorname from Donors union select DonorID ,Donorname from Donors", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbdonornames.DataSource = dt;
                cmbdonornames.DisplayMember = "Donorname";
                cmbdonornames.ValueMember = "DonorID";
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
        public Blooddonor()
        {
            InitializeComponent();
        }

        private void Btnaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbdonornames.SelectedIndex == 0)
                {
                    MessageBox.Show("please select a Donor name", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbdonornames.Focus();
                    return;
                }
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("enter Quantity", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Focus();
                    return;
                }
                float qty;
                qty = 0;
                if (!(float.TryParse(txtQuantity.Text, out qty)))
                {
                    MessageBox.Show("enter only numeric values", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Focus();
                    txtQuantity.Clear();
                    return;
                }
                qty =Convert.ToInt32( txtQuantity.Text);
                if (qty<500)
                {
                    MessageBox.Show("less than 500ml is not allowed", "invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Focus();
                    txtQuantity.Clear();
                    return;
                }
                if (con.State == ConnectionState.Closed) con.Open();
                if(btnaction.Text=="Save")
                {
                    cmd = new SqlCommand("select * from Bloodbank where Bloodtype='"+ txtbloodtype.Text + "' ", con);
                    dr = cmd.ExecuteReader();
                    if(dr.Read()==true)
                    {
                        int storeqty, newqty;
                        storeqty = Convert.ToInt32( dr.GetValue(2));
                        dr.Close();
                        newqty = storeqty + Convert.ToInt32(txtQuantity.Text);
                        cmd = new SqlCommand("update Bloodbank set Quantity='"+ newqty + "' where Bloodtype='" + txtbloodtype.Text + "' ", con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("select ISNULL(max( donorbloodid),0)+1 from Blooddonor", con);
                        int blooddonorid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                        //insert data for blooddonor table
                        cmd = new SqlCommand("insert into Blooddonor values('" + blooddonorid + "','" + cmbdonornames.SelectedValue + "','" + txtbloodtype.Text + "','" + txtQuantity.Text + "','" + dtpdonordate.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("blood bank Quantity  has been Updated successfully", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Fillblooddonordatagridview();
                        Clear();
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("select ISNULL(max( donorbloodid),0)+1 from Blooddonor", con);
                        Blooddonorid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                        cmd = new SqlCommand("select ISNULL(max( BloodID),0)+1 from Bloodbank", con);
                        int bloodid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                        //insert data for blooddonor table
                        cmd = new SqlCommand("insert into Blooddonor values('" + Blooddonorid + "','" + cmbdonornames.SelectedValue + "','" + txtbloodtype.Text + "','" + txtQuantity.Text + "','" + dtpdonordate.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        //insert data for bloodbank table
                        cmd = new SqlCommand("insert into Bloodbank values('" + bloodid + "', '" + txtbloodtype.Text + "', '" + txtQuantity.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("bloodbank data has been saved successfully", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Fillblooddonordatagridview();
                        Clear();
                    }
                    
                }
                else if(btnaction.Text == "Update")
                {
                    //--------cmd = new SqlCommand("Update Blooddonor set Donorbloodid='" + Blooddonorid + "',Donorname='" + cmbdonornames.SelectedValue + "',Bloodtype='" + txtbloodtype.Text + "',Quantity='" + txtQuantity.Text + "',donordate='" + dtpdonordate.Text + "' where Donorid='" + Blooddonorid + "'", con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("your data has been Updated successfully", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Fillblooddonordatagridview();
                    }
                    Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Blooddonor_Load(object sender, EventArgs e)
        {
            try
            {
                con = objcon.GetConnection();
                Filldonornames();
                Fillblooddonordatagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Cmbdonornames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbdonornames.SelectedIndex>0)
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    cmd = new SqlCommand("select bloodtype from Donors where donorid='"+cmbdonornames.SelectedValue+"'", con);
                    txtbloodtype.Text = cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Dgvblooddonor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 Blooddonorid= Convert.ToInt32(dgvblooddonor.CurrentRow.Cells[0].Value.ToString());
                cmbdonornames.SelectedValue = dgvblooddonor.CurrentRow.Cells[1].Value.ToString();
                txtbloodtype.Text = dgvblooddonor.CurrentRow.Cells[3].Value.ToString();
                txtQuantity.Text = dgvblooddonor.CurrentRow.Cells[4].Value.ToString();
                dtpdonordate.Text = dgvblooddonor.CurrentRow.Cells[5].Value.ToString();
                btnaction.Text = "Update";
       
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}

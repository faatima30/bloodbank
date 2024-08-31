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
    public partial class BloodSeeker : Form
    {
        Myconnection objcon = new Myconnection();//creating object
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();

        void Clear()
        {
            txtsseekername.Clear();
            cmbbloodtype.SelectedIndex = 0;
            txtqty.Clear();
            btnaction.Text = "save";
            txtsseekername.Focus();
            dtp.Text = System.DateTime.Today.ToShortDateString();
        }

        void Fillbloodseekerdatagridview()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd = new SqlCommand("select SeekerID,Seekername,bloodseeker.bloodid,bloodtype,Bloodseeker.Quantity,seekerdate from Bloodseeker join Bloodbank on Bloodseeker.BloodID=Bloodbank.BloodID", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvbloodseeker.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        void Fillbloodtypes()

        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd = new SqlCommand("select 0 as BloodID,'---select blood type---' as Bloodtype from Bloodbank union select BloodID ,Bloodtype from Bloodbank", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbbloodtype.DataSource = dt;
                cmbbloodtype.DisplayMember = "Bloodtype";
                cmbbloodtype.ValueMember = "BloodID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        public BloodSeeker()
        {
            InitializeComponent();
        }

        private void BloodSeeker_Load(object sender, EventArgs e)
        {
            try
            {
                con = objcon.GetConnection();
                Fillbloodseekerdatagridview();
                Fillbloodtypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Btnaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsseekername.Text == "")
                {
                    MessageBox.Show("enter your name", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsseekername.Focus();
                    return;
                }
                if (cmbbloodtype.SelectedIndex == 0)
                {
                    MessageBox.Show("please select a bloodtype", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbbloodtype.Focus();
                    return;
                }
                if (txtqty.Text == "")
                {
                    MessageBox.Show("enter Quantity", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtqty.Focus();
                    return;
                }
                float qty;
                qty = 0;
                if (!(float.TryParse(txtqty.Text, out qty)))
                {
                    MessageBox.Show("enter only numeric values", " invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtqty.Focus();
                    txtqty.Clear();
                    return;
                }


                if (con.State == ConnectionState.Closed) con.Open();
                cmd = new SqlCommand("select Quantity from Bloodbank where Bloodtype='"+cmbbloodtype.Text+"'", con);
                int storeqty, newqty;
                storeqty =Convert.ToInt32(cmd.ExecuteScalar());
                if(storeqty<Convert.ToInt32(txtqty.Text))
                {
                    MessageBox.Show("insufficient Blood Quantity", "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtqty.Clear();
                    txtqty.Focus();
                    return;
                }
                newqty = storeqty - Convert.ToInt32(txtqty.Text);
                cmd = new SqlCommand("update bloodbank set Quantity='"+newqty+ "' where  Bloodtype='" + cmbbloodtype.Text + "' ", con);
                cmd.ExecuteNonQuery();
                //bloodseeker registration
                cmd = new SqlCommand("select ISNULL(max( SeekerID),0)+1 from Bloodseeker", con);
                int Bloodseekerid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                cmd = new SqlCommand("insert into Bloodseeker values ('"+Bloodseekerid+ "','"+txtsseekername.Text+ "','"+cmbbloodtype.SelectedValue+ "','"+txtqty.Text+ "','"+dtp.Text+"') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bloodseeker data has been saved successfully", "SIU Blood Bank Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fillbloodseekerdatagridview();
                Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}

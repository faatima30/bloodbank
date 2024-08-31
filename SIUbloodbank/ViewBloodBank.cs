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
    public partial class ViewBloodBank : Form
    {
        Myconnection objcon = new Myconnection();//creating object
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        public ViewBloodBank()
        {
            InitializeComponent();
        }
        void Fillbloodbankdatagridview()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd = new SqlCommand("select * from bloodbank", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvbank.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void ViewBloodBank_Load(object sender, EventArgs e)
        {
            try
            {
                con = objcon.GetConnection();
                Fillbloodbankdatagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIU Blood Bank Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Dgvbank_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

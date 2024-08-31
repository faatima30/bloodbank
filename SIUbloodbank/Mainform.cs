using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIUbloodbank
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users objUsers = new Users();
            objUsers.ShowDialog();
        }

        private void DonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donors objDonors = new Donors();
            objDonors.ShowDialog();
        }

        private void BloodBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blooddonor objblooddonor = new Blooddonor();
            objblooddonor.ShowDialog();
        }

        private void ViewBloodBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBloodBank objviewBloodBank = new ViewBloodBank();
            objviewBloodBank.ShowDialog();
        }

        private void BloodSeekerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloodSeeker objbloodSeeker = new BloodSeeker();
            objbloodSeeker.ShowDialog();
        }
    }
}

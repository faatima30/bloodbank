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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(pbWelcome.Value!=pbWelcome.Maximum)
            {
                pbWelcome.Value = pbWelcome.Value + 1;
                if(pbWelcome.Value==pbWelcome.Maximum)
                {
                    Login objlogin = new Login();
                    objlogin.Show();
                    timer1.Enabled = false;
                    this.Hide(); 
                }
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}

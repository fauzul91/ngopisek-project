using NgopiSek_Project_PBO.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Project_PBO
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (loadingBar.Value + 3 <= loadingBar.Maximum)
            {
                loadingBar.Value += 3;
            }
            else
            {
                loadingBar.Value = loadingBar.Maximum;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

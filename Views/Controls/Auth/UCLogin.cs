using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.App.Core;
using NgopiSek_Desktop_App_V2.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Desktop_App_V2.Views.Controls
{
    public partial class UCLogin : UserControl
    {
        public event EventHandler RegisterClicked;
        public UCLogin()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidateInput();
        }

        public void ValidateInput()
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            int idRole; int idPengguna;
            bool isLoginSuccessful = AkunContext.Login(username, password, out idRole, out idPengguna);

            if (isLoginSuccessful)
            {
                Session.CurrentUserId = idPengguna;
                Form currentForm = this.FindForm(); // Dapatkan form Auth saat ini

                if (idRole == 1)
                {
                    MessageBox.Show("Login successful as Admin!");

                    var dashboard = new HomepageAdmin();
                    currentForm.Hide();
                    dashboard.FormClosed += (s, args) => currentForm.Close();
                    dashboard.Show();
                }
                else if (idRole == 2)
                {
                    MessageBox.Show("Login successful as Kasir!");

                    var homepageKasir = new HomepageKasir();
                    currentForm.Hide();
                    homepageKasir.FormClosed += (s, args) => currentForm.Close();
                    homepageKasir.Show();
                }
            }
            else
            {
                MessageBox.Show("Data tidak valid.");
            }
        }

        private void pressRegister_Click(object sender, EventArgs e)
        {
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

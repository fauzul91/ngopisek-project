using NgopiSek_Project_PBO.App.Contexts;
using NgopiSek_Project_PBO.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Project_PBO.Views.Controls
{
    public partial class UCLogin : UserControl
    {
        public event EventHandler RegisterClicked;
        public UCLogin()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.BackColor = ColorTranslator.FromHtml("#985722");
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.BackColor = ColorTranslator.FromHtml("#BA7337");
        }

        private void pressRegister_Click(object sender, EventArgs e)
        {
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            int idRole;
            bool isLoginSuccessful = AkunContext.Login(username, password, out idRole);

            if (isLoginSuccessful)
            {
                Form currentForm = this.FindForm();
                if (idRole == 1)
                {
                    MessageBox.Show("Login successful as Admin!");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();                    
                }
                else if (idRole == 2)
                {
                    MessageBox.Show("Login successful as Kasir!");
                    POSKasir posKasir = new POSKasir();
                    posKasir.Show();
                }
                currentForm.Close();
            }
            else
            {
                MessageBox.Show("Data tidak valid.");
            }
        }
    }
}

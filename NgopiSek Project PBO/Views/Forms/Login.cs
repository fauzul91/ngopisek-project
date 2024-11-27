using NgopiSek_Project_PBO.Views.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Project_PBO.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoadLoginControl();
        }

        private void LoadLoginControl()
        {
            UCLogin uCLogin = new UCLogin();
            uCLogin.RegisterClicked += UCLogin_RegisterClicked;
            addUserControl(uCLogin);
        }

        private void LoadRegisterControl()
        {
            UCRegister uCRegister = new UCRegister();
            uCRegister.LoginClicked += UCRegister_LoginClicked;
            addUserControl(uCRegister);
        }

        private void UCLogin_RegisterClicked(object sender, EventArgs e)
        {
            LoadRegisterControl();
        }

        private void UCRegister_LoginClicked(object sender, EventArgs e)
        {
            LoadLoginControl();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelLogin.Controls.Clear();
            panelLogin.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}

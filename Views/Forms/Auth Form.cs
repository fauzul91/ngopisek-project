using NgopiSek_Desktop_App_V2.Views.Controls;

namespace NgopiSek_Desktop_App_V2
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
            LoadLoginForm();
        }

        private void LoadLoginForm()
        {
            UCLogin loginForm = new UCLogin();
            loginForm.RegisterClicked += UCLogin_RegisterClicked;
            AddUserControl(loginForm);
        }

        private void LoadRegisterForm()
        {
            UCRegister registerForm = new UCRegister();
            registerForm.LoginClicked += UCRegister_LoginClicked;
            AddUserControl(registerForm);
        }        

        public void UCLogin_RegisterClicked(object sender, EventArgs e)
        {
            LoadRegisterForm();
        }

        public void UCRegister_LoginClicked(object sender, EventArgs e)
        {
            LoadLoginForm();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAuth.Controls.Clear();
            panelAuth.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}

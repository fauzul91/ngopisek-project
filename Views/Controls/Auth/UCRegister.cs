using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace NgopiSek_Desktop_App_V2.Views.Controls
{
    public partial class UCRegister : UserControl
    {
        public event EventHandler LoginClicked;
        public event EventHandler RegistrationCompleted;
        private readonly string PASSKEY = ConfigurationManager.AppSettings["Passkey"];
        public int PenggunaId { get; set; }

        public UCRegister()
        {
            InitializeComponent();
            LoadRoleData();
            textPassword.PasswordChar = '*';
            textConfirmPassword.PasswordChar = '*';
            textPasskey.PasswordChar = '*';
        }

        private void pressLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

        private void LoadRoleData()
        {
            comboRole.Items.Clear();
            comboRole.Items.Add("Admin");
            comboRole.Items.Add("Kasir");
            comboRole.SelectedIndex = -1;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textUsername.Text) ||
                string.IsNullOrWhiteSpace(textPassword.Text) ||
                string.IsNullOrWhiteSpace(textConfirmPassword.Text) ||
                string.IsNullOrWhiteSpace(textPasskey.Text))
            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textName.Clear();
            textUsername.Clear();
            textPassword.Clear();
            textConfirmPassword.Clear();
            textPasskey.Clear();
            comboRole.SelectedIndex = -1;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            if (textPassword.Text != textConfirmPassword.Text)
            {
                MessageBox.Show("Password dan Confirm Password tidak sesuai.");
                return;
            }

            if (textPasskey.Text != PASSKEY)
            {
                MessageBox.Show("Passkey tidak valid.");
                return;
            }

            int selectedRoleId = comboRole.SelectedIndex == 0 ? 1 : 2; // 0 -> Admin, 1 -> Kasir

            M_Pengguna pengguna = new M_Pengguna
            {
                nama_pengguna = textName.Text,
                username_pengguna = textUsername.Text,
                password_pengguna = textPassword.Text,
                id_role = selectedRoleId,
            };

            pengguna.id_pengguna = PenggunaId;
            bool registrasiSuccess = AkunContext.Registrasi(pengguna);

            if (registrasiSuccess)
            {
                MessageBox.Show("Akun berhasil ditambahkan");
                ClearFields();
                RegistrationCompleted?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Terjadi kesalahan saat registrasi");
            }
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
            }
        }

        private void btnEye2_Click(object sender, EventArgs e)
        {
            if (textConfirmPassword.PasswordChar == '*')
            {
                textConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textConfirmPassword.PasswordChar = '*';
            }
        }
    }
}

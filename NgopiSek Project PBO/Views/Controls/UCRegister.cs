using NgopiSek_Project_PBO.App.Contexts;
using NgopiSek_Project_PBO.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NgopiSek_Project_PBO.Views.Controls
{
    public partial class UCRegister : UserControl
    {
        private const string PASSKEY = "5500";
        public event EventHandler RegistrationCompleted;
        public bool IsEditMode { get; set; } = false;
        public int PenggunaId { get; set; }

        public event EventHandler LoginClicked;
        public UCRegister()
        {
            InitializeComponent();
            LoadRoleData();
            textPassword.PasswordChar = '*';
            textConfirmPassword.PasswordChar = '*';
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = ColorTranslator.FromHtml("#985722");
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = ColorTranslator.FromHtml("#BA7337");
        }

        private void pressLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            if (textPasskey.Text != PASSKEY)
            {
                MessageBox.Show("Passkey tidak valid");
                return;
            }

            // Tentukan ID role berdasarkan pilihan combo box
            int selectedRoleId = comboRole.SelectedIndex == 0 ? 1 : 2; // 0 -> Admin, 1 -> Kasir

            M_Pengguna pengguna = new M_Pengguna
            {
                nama_pengguna = textName.Text,
                username_pengguna = textUsername.Text,
                password_pengguna = textPassword.Text,
                id_role = selectedRoleId,  // Gunakan ID role yang ditentukan
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

        private void LoadRoleData()
        {
            comboRole.Items.Clear();
            comboRole.Items.Add("Admin");  // Index 0 -> ID role = 1
            comboRole.Items.Add("Kasir");  // Index 1 -> ID role = 2
            comboRole.SelectedIndex = -1; // Tidak ada pilihan default
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
    }
}
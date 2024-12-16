using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.App.Core;
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

namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    public partial class UCProfil : UserControl
    {
        public UCProfil()
        {
            InitializeComponent();
            LoadWelcomingUser();
            LoadProfile();
            LoadUsername();
            LoadRole();
        }
        private void LoadWelcomingUser()
        {
            try
            {
                int idPengguna = Session.CurrentUserId;
                DataTable usernameData = AkunContext.GetUsername(idPengguna);
                if (usernameData != null && usernameData.Rows.Count > 0)
                {
                    textNameUser.Text = usernameData.Rows[0]["nama_pengguna"].ToString();
                }
            }
            catch (Exception ex)
            {
                textName.Text = "Error";
                Console.WriteLine("Error loading username: " + ex.Message);
            }
        }
        private void LoadProfile()
        {
            var pengguna = AkunContext.GetUserById(Session.CurrentUserId);
            if (pengguna != null)
            {
                textName.Text = pengguna.nama_pengguna;
                textUsername.Text = pengguna.username_pengguna;
                textPassword.Text = string.Empty;
                textConfirmPassword.Text = string.Empty;

                if (pengguna.foto_pengguna != null)
                {
                    try
                    {
                        userPicture.Image = ByteArrayToImage(pengguna.foto_pengguna);
                        userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        userPicture.Image = Properties.Resources.Orang_Sukses;
                        userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    userPicture.Image = Properties.Resources.Orang_Sukses;
                    userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                MessageBox.Show("Gagal memuat data profil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                Console.WriteLine("Byte array is empty or null.");
                return Properties.Resources.Orang_Sukses;
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textUsername.Text))
            {
                MessageBox.Show("Nama dan Username tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(textPassword.Text) && textPassword.Text != textConfirmPassword.Text)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak sesuai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Pilih Foto Profil"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    userPicture.Image = Image.FromFile(openFileDialog.FileName);
                    userPicture.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var pengguna = AkunContext.GetUserById(Session.CurrentUserId);
            if (pengguna == null)
            {
                MessageBox.Show("Pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pengguna.nama_pengguna = textName.Text;
            pengguna.username_pengguna = textUsername.Text;

            if (!string.IsNullOrEmpty(textPassword.Text))
            {
                pengguna.password_pengguna = textPassword.Text;
            }

            if (userPicture.Image != null)
            {
                try
                {
                    ImageConverter converter = new ImageConverter();
                    pengguna.foto_pengguna = (byte[])converter.ConvertTo(userPicture.Image, typeof(byte[]));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal mengonversi gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bool isUpdated = AkunContext.Update(pengguna);
            if (isUpdated)
            {
                MessageBox.Show("Profil berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal memperbarui profil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsername()
        {
            try
            {
                int idPengguna = Session.CurrentUserId;
                DataTable usernameData = AkunContext.GetUsername(idPengguna);
                if (usernameData != null && usernameData.Rows.Count > 0)
                {
                    textNameProfile.Text = usernameData.Rows[0]["nama_pengguna"].ToString();
                }
            }
            catch (Exception ex)
            {
                textNameProfile.Text = "Error";
                Console.WriteLine("Error loading username: " + ex.Message);
            }
        }

        private void LoadRole()
        {
            try
            {
                int idPengguna = Session.CurrentUserId;
                DataTable usernameData = AkunContext.GetRole(idPengguna);
                if (usernameData != null && usernameData.Rows.Count > 0)
                {
                    textRoleProfile.Text = usernameData.Rows[0]["nama_role"].ToString();
                }
            }
            catch (Exception ex)
            {
                textRoleProfile.Text = "Error";
                Console.WriteLine("Error loading username: " + ex.Message);
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

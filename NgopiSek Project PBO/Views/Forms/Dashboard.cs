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

namespace NgopiSek_Project_PBO.Views.Forms
{
    public partial class Dashboard : Form
    {
        bool sideBarExpand;
        public Dashboard()
        {
            InitializeComponent();
            RemoveButtonOutline(this);
        }
        private void RemoveButtonOutline(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                }
                else if (control.HasChildren)
                {
                    RemoveButtonOutline(control);
                }
            }
        }

        private void timerSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBarDashboard.Width -= 10;
                if (sideBarDashboard.Width == sideBarDashboard.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    timerSideBar.Stop();
                }
            }
            else
            {
                sideBarDashboard.Width += 10;
                if (sideBarDashboard.Width == sideBarDashboard.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    timerSideBar.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSideBar.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UCHome home = new UCHome();
            AddUserControl(home);
            SetActiveMenu(btnHome);
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            UCProduk produk = new UCProduk();
            AddUserControl(produk);
            SetActiveMenu(btnProduk);
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            UCKategori kategori = new UCKategori();
            AddUserControl(kategori);
            SetActiveMenu(btnKategori);
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            UCTransaksi pesanan = new UCTransaksi();
            AddUserControl(pesanan);
            SetActiveMenu(btnPesanan);
        }

        private void SetActiveMenu(Button activeButton)
        {
            // Aktifkan semua tombol
            btnHome.Enabled = true;
            btnProduk.Enabled = true;
            btnKategori.Enabled = true;
            btnPesanan.Enabled = true;

            // Nonaktifkan tombol yang sedang aktif
            activeButton.Enabled = false;
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}

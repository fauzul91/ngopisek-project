using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.Views.Controls.Kasir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    public partial class HomepageKasir : Form
    {
        private UC_HomeKasir homeKasir;

        public HomepageKasir()
        {
            InitializeComponent();
            LoadKasirData();
            InitializeUCs();
            btnHome.Enabled = false;
        }

        private void InitializeUCs()
        {
            homeKasir = new UC_HomeKasir();
            AddUserControl(homeKasir); 
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelKasir.Controls.Clear();
            panelKasir.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void LoadKasirData()
        {
            UC_HomeKasir homeKasir = new UC_HomeKasir();
            AddUserControl(homeKasir);
        }
                
        private void LoadOrderHistoryData()
        {

        }

        private void SetActiveMenu(Button activeButton)
        {
            btnHome.Enabled = true;
            btnOrderHistory.Enabled = true;

            activeButton.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadKasirData();
            SetActiveMenu(btnHome);
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            LoadOrderHistoryData();
            SetActiveMenu(btnOrderHistory);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }            
        }
    }
}

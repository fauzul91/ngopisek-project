using NgopiSek_Desktop_App_V2.Views.Controls.Admin;
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
    public partial class HomepageAdmin : Form
    {
        public HomepageAdmin()
        {
            InitializeComponent();
            btnHome_Click(this, EventArgs.Empty);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Authentication auth = new Authentication();
                auth.ShowDialog();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UCHome home = new UCHome();
            AddUserControl(home);
            SetActiveMenu(btnHome);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            UCProduct product = new UCProduct();
            AddUserControl(product);
            SetActiveMenu(btnProduct);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            UCCategory category = new UCCategory();
            AddUserControl(category);
            SetActiveMenu(btnCategory);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            UCOrder order = new UCOrder();
            AddUserControl(order);
            SetActiveMenu(btnOrder);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SetActiveMenu(Button activeButton)
        {
            btnHome.Enabled = true;
            btnProduct.Enabled = true;
            btnCategory.Enabled = true;
            btnOrder.Enabled = true;

            activeButton.Enabled = false;
        }
    }
}

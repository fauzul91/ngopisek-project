namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    partial class HomepageKasir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogout = new Button();
            btnOrderHistory = new Button();
            btnHome = new Button();
            panelKasir = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Side_Panel_Homepage_kasir1;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnOrderHistory);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 1166);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = Properties.Resources.Logout;
            btnLogout.Location = new Point(37, 952);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(89, 74);
            btnLogout.TabIndex = 2;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.BackColor = Color.Transparent;
            btnOrderHistory.FlatAppearance.BorderSize = 0;
            btnOrderHistory.FlatStyle = FlatStyle.Flat;
            btnOrderHistory.Image = Properties.Resources.Order_Icon;
            btnOrderHistory.Location = new Point(39, 382);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Size = new Size(89, 74);
            btnOrderHistory.TabIndex = 1;
            btnOrderHistory.UseVisualStyleBackColor = false;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = Properties.Resources.Home_Icon;
            btnHome.Location = new Point(39, 251);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(89, 74);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelKasir
            // 
            panelKasir.Location = new Point(178, 0);
            panelKasir.Name = "panelKasir";
            panelKasir.Size = new Size(1730, 1174);
            panelKasir.TabIndex = 2;
            // 
            // HomepageKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1166);
            Controls.Add(panel1);
            Controls.Add(panelKasir);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "HomepageKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomepageKasir";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHome;
        private Button btnOrderHistory;
        private Button btnLogout;
        private Panel panelKasir;
    }
}
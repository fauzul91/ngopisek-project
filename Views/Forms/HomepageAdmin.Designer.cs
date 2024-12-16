namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    partial class HomepageAdmin
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
            btnProfile = new Button();
            btnPayment = new Button();
            btnLogout = new Button();
            btnOrder = new Button();
            btnCategory = new Button();
            btnProduct = new Button();
            btnHome = new Button();
            panelAdmin = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Side_Homepage_Admin_Panel;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 1166);
            panel1.TabIndex = 0;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.FromArgb(60, 60, 60);
            btnProfile.Image = Properties.Resources.Icon_Profile;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(70, 689);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(24, 0, 0, 0);
            btnProfile.Size = new Size(246, 64);
            btnProfile.TabIndex = 6;
            btnProfile.Text = "      Profil";
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Transparent;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.FromArgb(60, 60, 60);
            btnPayment.Image = Properties.Resources.Payment_Icon1;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(70, 590);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(24, 0, 0, 0);
            btnPayment.Size = new Size(246, 64);
            btnPayment.TabIndex = 5;
            btnPayment.Text = "      Payment";
            btnPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(60, 60, 60);
            btnLogout.Image = Properties.Resources.Log_Out;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(70, 990);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(246, 64);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "     Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Transparent;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.FromArgb(60, 60, 60);
            btnOrder.Image = Properties.Resources.basket_svgrepo_com_1;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(70, 498);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(20, 0, 0, 0);
            btnOrder.Size = new Size(246, 64);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "      Order";
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Transparent;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategory.ForeColor = Color.FromArgb(60, 60, 60);
            btnCategory.Image = Properties.Resources.category_svgrepo_com_1;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(70, 407);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(20, 0, 0, 0);
            btnCategory.Size = new Size(246, 64);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "       Category";
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.FromArgb(60, 60, 60);
            btnProduct.Image = Properties.Resources.product_svgrepo_com_1;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(70, 319);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(20, 0, 0, 0);
            btnProduct.Size = new Size(246, 64);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "      Product";
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(60, 60, 60);
            btnHome.Image = Properties.Resources.home_svgrepo_com_1;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(70, 228);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(20, 0, 0, 0);
            btnHome.Size = new Size(246, 64);
            btnHome.TabIndex = 0;
            btnHome.Text = "       Home Page";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.FromArgb(246, 246, 246);
            panelAdmin.Dock = DockStyle.Right;
            panelAdmin.Location = new Point(384, 0);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(1510, 1166);
            panelAdmin.TabIndex = 1;
            // 
            // HomepageAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1166);
            Controls.Add(panelAdmin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "HomepageAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelAdmin;
        private Button btnHome;
        private Button btnProduct;
        private Button btnOrder;
        private Button btnCategory;
        private Button btnLogout;
        private Button btnPayment;
        private Button btnProfile;
    }
}
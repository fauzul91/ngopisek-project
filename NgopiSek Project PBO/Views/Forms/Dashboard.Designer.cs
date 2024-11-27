namespace NgopiSek_Project_PBO.Views.Forms
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            sideBarDashboard = new Panel();
            menu = new Label();
            btnMenu = new PictureBox();
            btnLogOut = new Button();
            btnPesanan = new Button();
            btnKategori = new Button();
            btnProduk = new Button();
            btnHome = new Button();
            timerSideBar = new System.Windows.Forms.Timer(components);
            panelDashboard = new Panel();
            sideBarDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // sideBarDashboard
            // 
            sideBarDashboard.BackColor = Color.FromArgb(186, 115, 55);
            sideBarDashboard.Controls.Add(menu);
            sideBarDashboard.Controls.Add(btnMenu);
            sideBarDashboard.Controls.Add(btnLogOut);
            sideBarDashboard.Controls.Add(btnPesanan);
            sideBarDashboard.Controls.Add(btnKategori);
            sideBarDashboard.Controls.Add(btnProduk);
            sideBarDashboard.Controls.Add(btnHome);
            sideBarDashboard.Dock = DockStyle.Left;
            sideBarDashboard.Location = new Point(0, 0);
            sideBarDashboard.MaximumSize = new Size(447, 1166);
            sideBarDashboard.MinimumSize = new Size(187, 1166);
            sideBarDashboard.Name = "sideBarDashboard";
            sideBarDashboard.Size = new Size(447, 1166);
            sideBarDashboard.TabIndex = 0;
            // 
            // menu
            // 
            menu.AutoSize = true;
            menu.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.ForeColor = Color.White;
            menu.Location = new Point(186, 81);
            menu.Name = "menu";
            menu.Size = new Size(84, 42);
            menu.TabIndex = 1;
            menu.Text = "Menu";
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = Properties.Resources.Hamburger_Menu;
            btnMenu.InitialImage = Properties.Resources.Hamburger_Menu;
            btnMenu.Location = new Point(75, 81);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(52, 40);
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(186, 115, 55);
            btnLogOut.BackgroundImageLayout = ImageLayout.None;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = Properties.Resources.Log_Out_Icon;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(53, 968);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(20, 0, 0, 0);
            btnLogOut.Size = new Size(331, 87);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "           Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnPesanan
            // 
            btnPesanan.BackColor = Color.FromArgb(186, 115, 55);
            btnPesanan.BackgroundImageLayout = ImageLayout.None;
            btnPesanan.FlatStyle = FlatStyle.Flat;
            btnPesanan.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesanan.ForeColor = Color.White;
            btnPesanan.Image = Properties.Resources.Pesanan_Icon;
            btnPesanan.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesanan.Location = new Point(53, 552);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Padding = new Padding(15, 0, 0, 0);
            btnPesanan.Size = new Size(331, 87);
            btnPesanan.TabIndex = 4;
            btnPesanan.Text = "          Pesanan";
            btnPesanan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesanan.UseVisualStyleBackColor = false;
            btnPesanan.Click += btnPesanan_Click;
            // 
            // btnKategori
            // 
            btnKategori.BackColor = Color.FromArgb(186, 115, 55);
            btnKategori.BackgroundImageLayout = ImageLayout.None;
            btnKategori.FlatStyle = FlatStyle.Flat;
            btnKategori.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKategori.ForeColor = Color.White;
            btnKategori.Image = Properties.Resources.Category_Icon;
            btnKategori.ImageAlign = ContentAlignment.MiddleLeft;
            btnKategori.Location = new Point(53, 456);
            btnKategori.Name = "btnKategori";
            btnKategori.Padding = new Padding(15, 0, 0, 0);
            btnKategori.Size = new Size(331, 87);
            btnKategori.TabIndex = 3;
            btnKategori.Text = "            Kategori";
            btnKategori.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKategori.UseVisualStyleBackColor = false;
            btnKategori.Click += btnKategori_Click;
            // 
            // btnProduk
            // 
            btnProduk.BackColor = Color.FromArgb(186, 115, 55);
            btnProduk.BackgroundImageLayout = ImageLayout.None;
            btnProduk.FlatStyle = FlatStyle.Flat;
            btnProduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduk.ForeColor = Color.White;
            btnProduk.Image = Properties.Resources.Product_Icon;
            btnProduk.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduk.Location = new Point(53, 361);
            btnProduk.Name = "btnProduk";
            btnProduk.Padding = new Padding(15, 0, 0, 0);
            btnProduk.Size = new Size(331, 87);
            btnProduk.TabIndex = 2;
            btnProduk.Text = "          Produk";
            btnProduk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduk.UseVisualStyleBackColor = false;
            btnProduk.Click += btnProduk_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(186, 115, 55);
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.Home_Icon;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(53, 267);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(20, 0, 0, 0);
            btnHome.Size = new Size(331, 87);
            btnHome.TabIndex = 1;
            btnHome.Text = "           Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // timerSideBar
            // 
            timerSideBar.Interval = 10;
            timerSideBar.Tick += timerSideBar_Tick;
            // 
            // panelDashboard
            // 
            panelDashboard.Dock = DockStyle.Right;
            panelDashboard.Location = new Point(446, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1452, 1166);
            panelDashboard.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1166);
            Controls.Add(panelDashboard);
            Controls.Add(sideBarDashboard);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardAdmin";
            sideBarDashboard.ResumeLayout(false);
            sideBarDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBarDashboard;
        private Button btnLogOut;
        private Button btnPesanan;
        private Button btnKategori;
        private Button btnProduk;
        private Button btnHome;
        private Label menu;
        private PictureBox btnMenu;
        private System.Windows.Forms.Timer timerSideBar;
        private Panel panelDashboard;
    }
}
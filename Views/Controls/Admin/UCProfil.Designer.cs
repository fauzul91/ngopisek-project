namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    partial class UCProfil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            textRoleProfile = new Label();
            textNameProfile = new Label();
            btnCamera = new Button();
            userPicture = new PictureBox();
            panel3 = new Panel();
            btnSimpan = new Button();
            panel4 = new Panel();
            btnEye2 = new Button();
            btnEye = new Button();
            textConfirmPassword = new TextBox();
            textPassword = new TextBox();
            textUsername = new TextBox();
            textName = new TextBox();
            textNameUser = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Top_Side;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(textNameUser);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1510, 280);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Panel_Bg;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(textRoleProfile);
            panel2.Controls.Add(textNameProfile);
            panel2.Controls.Add(btnCamera);
            panel2.Controls.Add(userPicture);
            panel2.Location = new Point(59, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 773);
            panel2.TabIndex = 0;
            // 
            // textRoleProfile
            // 
            textRoleProfile.AutoSize = true;
            textRoleProfile.Font = new Font("Gilroy-Medium", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textRoleProfile.Location = new Point(75, 536);
            textRoleProfile.Name = "textRoleProfile";
            textRoleProfile.Size = new Size(68, 24);
            textRoleProfile.TabIndex = 3;
            textRoleProfile.Text = "Admin";
            textRoleProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textNameProfile
            // 
            textNameProfile.AutoSize = true;
            textNameProfile.Font = new Font("Gilroy-Bold", 13.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNameProfile.Location = new Point(70, 489);
            textNameProfile.Name = "textNameProfile";
            textNameProfile.Size = new Size(250, 35);
            textNameProfile.TabIndex = 2;
            textNameProfile.Text = "Andre Firmansyah";
            // 
            // btnCamera
            // 
            btnCamera.BackColor = Color.FromArgb(255, 145, 83);
            btnCamera.BackgroundImage = Properties.Resources.Camera_Icon3;
            btnCamera.BackgroundImageLayout = ImageLayout.Center;
            btnCamera.FlatAppearance.BorderSize = 0;
            btnCamera.FlatStyle = FlatStyle.Flat;
            btnCamera.Location = new Point(355, 373);
            btnCamera.Margin = new Padding(10, 3, 3, 3);
            btnCamera.Name = "btnCamera";
            btnCamera.Padding = new Padding(20, 20, 0, 0);
            btnCamera.Size = new Size(77, 63);
            btnCamera.TabIndex = 1;
            btnCamera.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCamera.UseVisualStyleBackColor = false;
            btnCamera.Click += btnCamera_Click;
            // 
            // userPicture
            // 
            userPicture.BackColor = Color.Transparent;
            userPicture.BackgroundImageLayout = ImageLayout.Zoom;
            userPicture.BorderStyle = BorderStyle.FixedSingle;
            userPicture.Location = new Point(79, 157);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(330, 306);
            userPicture.TabIndex = 0;
            userPicture.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Panel_Bg2;
            panel3.Controls.Add(btnSimpan);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(564, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(892, 773);
            panel3.TabIndex = 1;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(255, 145, 83);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(93, 676);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(189, 51);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "Save Profile";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Profile_Box1;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(btnEye2);
            panel4.Controls.Add(btnEye);
            panel4.Controls.Add(textConfirmPassword);
            panel4.Controls.Add(textPassword);
            panel4.Controls.Add(textUsername);
            panel4.Controls.Add(textName);
            panel4.Location = new Point(71, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(728, 555);
            panel4.TabIndex = 1;
            // 
            // btnEye2
            // 
            btnEye2.BackColor = Color.FromArgb(247, 250, 252);
            btnEye2.BackgroundImage = Properties.Resources.eye_svgrepo_com;
            btnEye2.BackgroundImageLayout = ImageLayout.Stretch;
            btnEye2.FlatAppearance.BorderSize = 0;
            btnEye2.FlatStyle = FlatStyle.Flat;
            btnEye2.Location = new Point(651, 506);
            btnEye2.Name = "btnEye2";
            btnEye2.Size = new Size(40, 40);
            btnEye2.TabIndex = 10;
            btnEye2.UseVisualStyleBackColor = false;
            btnEye2.Click += btnEye2_Click;
            // 
            // btnEye
            // 
            btnEye.BackColor = Color.FromArgb(247, 250, 252);
            btnEye.BackgroundImage = Properties.Resources.eye_svgrepo_com;
            btnEye.BackgroundImageLayout = ImageLayout.Stretch;
            btnEye.FlatAppearance.BorderSize = 0;
            btnEye.FlatStyle = FlatStyle.Flat;
            btnEye.Location = new Point(651, 358);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(40, 40);
            btnEye.TabIndex = 9;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.Click += btnEye_Click;
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.BackColor = Color.FromArgb(251, 251, 251);
            textConfirmPassword.BorderStyle = BorderStyle.None;
            textConfirmPassword.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textConfirmPassword.Location = new Point(35, 511);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.Size = new Size(656, 30);
            textConfirmPassword.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(251, 251, 251);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(35, 363);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(656, 30);
            textPassword.TabIndex = 2;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(251, 251, 251);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(35, 216);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(656, 30);
            textUsername.TabIndex = 1;
            // 
            // textName
            // 
            textName.BackColor = Color.FromArgb(251, 251, 251);
            textName.BorderStyle = BorderStyle.None;
            textName.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(35, 70);
            textName.Name = "textName";
            textName.Size = new Size(656, 30);
            textName.TabIndex = 0;
            // 
            // textNameUser
            // 
            textNameUser.AutoSize = true;
            textNameUser.BackColor = Color.Transparent;
            textNameUser.Font = new Font("Gilroy-Bold", 24F);
            textNameUser.ForeColor = Color.White;
            textNameUser.Location = new Point(292, 73);
            textNameUser.Name = "textNameUser";
            textNameUser.Size = new Size(156, 59);
            textNameUser.TabIndex = 3;
            textNameUser.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gilroy-Bold", 24F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 72);
            label1.Name = "label1";
            label1.Size = new Size(256, 59);
            label1.TabIndex = 2;
            label1.Text = "Welcome, ";
            // 
            // UCProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCProfil";
            Size = new Size(1510, 1166);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPicture).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnCamera;
        private PictureBox userPicture;
        private Label textRoleProfile;
        private Label textNameProfile;
        private Panel panel4;
        private TextBox textConfirmPassword;
        private TextBox textPassword;
        private TextBox textUsername;
        private TextBox textName;
        private Button btnSimpan;
        private Button btnEye2;
        private Button btnEye;
        private Label textNameUser;
        private Label label1;
    }
}

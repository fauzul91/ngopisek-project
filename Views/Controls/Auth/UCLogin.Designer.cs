namespace NgopiSek_Desktop_App_V2.Views.Controls
{
    partial class UCLogin
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
            btnEye = new Button();
            textPassword = new TextBox();
            textUsername = new TextBox();
            btnLogin = new Button();
            pressRegister = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Login_Form;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnEye);
            panel1.Controls.Add(textPassword);
            panel1.Controls.Add(textUsername);
            panel1.Location = new Point(222, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 559);
            panel1.TabIndex = 0;
            // 
            // btnEye
            // 
            btnEye.BackColor = Color.FromArgb(247, 250, 252);
            btnEye.BackgroundImage = Properties.Resources.eye_svgrepo_com;
            btnEye.BackgroundImageLayout = ImageLayout.Stretch;
            btnEye.FlatAppearance.BorderSize = 0;
            btnEye.FlatStyle = FlatStyle.Flat;
            btnEye.Location = new Point(607, 484);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(40, 40);
            btnEye.TabIndex = 2;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.Click += btnEye_Click;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(247, 250, 252);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Cursor = Cursors.IBeam;
            textPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.ForeColor = Color.FromArgb(53, 53, 53);
            textPassword.Location = new Point(20, 489);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(643, 36);
            textPassword.TabIndex = 1;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(247, 250, 252);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Cursor = Cursors.IBeam;
            textUsername.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.ForeColor = Color.FromArgb(53, 53, 53);
            textUsername.Location = new Point(20, 319);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(643, 36);
            textUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 145, 83);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(224, 792);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(675, 60);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pressRegister
            // 
            pressRegister.AutoSize = true;
            pressRegister.Cursor = Cursors.Hand;
            pressRegister.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pressRegister.Location = new Point(588, 865);
            pressRegister.Name = "pressRegister";
            pressRegister.Size = new Size(99, 36);
            pressRegister.TabIndex = 2;
            pressRegister.Text = "Register";
            pressRegister.Click += pressRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Gilroy-Medium", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(400, 869);
            label1.Name = "label1";
            label1.Size = new Size(189, 24);
            label1.TabIndex = 3;
            label1.Text = "Belum punya akun?";
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            Controls.Add(label1);
            Controls.Add(pressRegister);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Name = "UCLogin";
            Size = new Size(1147, 1166);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textUsername;
        private Button btnLogin;
        private Label pressRegister;
        private TextBox textPassword;
        private Label label1;
        private Button btnEye;
    }
}

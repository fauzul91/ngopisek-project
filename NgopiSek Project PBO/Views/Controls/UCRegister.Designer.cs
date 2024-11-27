namespace NgopiSek_Project_PBO.Views.Controls
{
    partial class UCRegister
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
            comboRole = new ComboBox();
            textPasskey = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textConfirmPassword = new TextBox();
            label6 = new Label();
            textPassword = new TextBox();
            label7 = new Label();
            pressLogin = new Label();
            label4 = new Label();
            btnRegister = new Button();
            textUsername = new TextBox();
            label3 = new Label();
            textName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboRole
            // 
            comboRole.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(239, 724);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(680, 58);
            comboRole.TabIndex = 42;
            // 
            // textPasskey
            // 
            textPasskey.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPasskey.Location = new Point(234, 843);
            textPasskey.Name = "textPasskey";
            textPasskey.Size = new Size(687, 49);
            textPasskey.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(234, 798);
            label8.Name = "label8";
            label8.Size = new Size(250, 42);
            label8.TabIndex = 40;
            label8.Text = "Passkey (Required)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(234, 679);
            label9.Name = "label9";
            label9.Size = new Size(69, 42);
            label9.TabIndex = 39;
            label9.Text = "Role";
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textConfirmPassword.Location = new Point(234, 607);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.Size = new Size(687, 49);
            textConfirmPassword.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 562);
            label6.Name = "label6";
            label6.Size = new Size(237, 42);
            label6.TabIndex = 37;
            label6.Text = "Confirm Password";
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(234, 492);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(687, 49);
            textPassword.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(234, 447);
            label7.Name = "label7";
            label7.Size = new Size(134, 42);
            label7.TabIndex = 35;
            label7.Text = "Password";
            // 
            // pressLogin
            // 
            pressLogin.AutoSize = true;
            pressLogin.Cursor = Cursors.Hand;
            pressLogin.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pressLogin.ForeColor = Color.Black;
            pressLogin.Location = new Point(632, 1056);
            pressLogin.Name = "pressLogin";
            pressLogin.Size = new Size(55, 28);
            pressLogin.TabIndex = 34;
            pressLogin.Text = "Login";
            pressLogin.Click += pressLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(467, 1056);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 33;
            label4.Text = "Sudah punya akun?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(186, 115, 55);
            btnRegister.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(234, 965);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(685, 79);
            btnRegister.TabIndex = 32;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            btnRegister.MouseEnter += btnRegister_MouseEnter;
            btnRegister.MouseLeave += btnRegister_MouseLeave;
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(234, 375);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(687, 49);
            textUsername.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 330);
            label3.Name = "label3";
            label3.Size = new Size(142, 42);
            label3.TabIndex = 30;
            label3.Text = "Username";
            // 
            // textName
            // 
            textName.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(234, 260);
            textName.Name = "textName";
            textName.Size = new Size(687, 49);
            textName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 215);
            label2.Name = "label2";
            label2.Size = new Size(91, 42);
            label2.TabIndex = 28;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 76);
            label1.Name = "label1";
            label1.Size = new Size(875, 127);
            label1.TabIndex = 27;
            label1.Text = "Welcome To NgopiSek";
            // 
            // UCRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboRole);
            Controls.Add(textPasskey);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textConfirmPassword);
            Controls.Add(label6);
            Controls.Add(textPassword);
            Controls.Add(label7);
            Controls.Add(pressLogin);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(textUsername);
            Controls.Add(label3);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCRegister";
            Size = new Size(1145, 1162);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboRole;
        private TextBox textPasskey;
        private Label label8;
        private Label label9;
        private TextBox textConfirmPassword;
        private Label label6;
        private TextBox textPassword;
        private Label label7;
        private Label pressLogin;
        private Label label4;
        private Button btnRegister;
        private TextBox textUsername;
        private Label label3;
        private TextBox textName;
        private Label label2;
        private Label label1;
    }
}

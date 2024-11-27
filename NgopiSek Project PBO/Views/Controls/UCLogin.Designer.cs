namespace NgopiSek_Project_PBO.Views.Controls
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
            pressRegister = new Label();
            label4 = new Label();
            btnSignIn = new Button();
            textPassword = new TextBox();
            label3 = new Label();
            textUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // pressRegister
            // 
            pressRegister.AutoSize = true;
            pressRegister.Cursor = Cursors.Hand;
            pressRegister.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pressRegister.ForeColor = Color.Black;
            pressRegister.Location = new Point(613, 905);
            pressRegister.Name = "pressRegister";
            pressRegister.Size = new Size(78, 28);
            pressRegister.TabIndex = 18;
            pressRegister.Text = "Register";
            pressRegister.Click += pressRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(448, 905);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 17;
            label4.Text = "Belum punya akun?";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(186, 115, 55);
            btnSignIn.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(240, 814);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(685, 79);
            btnSignIn.TabIndex = 16;
            btnSignIn.Text = "SIgn In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            btnSignIn.MouseEnter += btnSignIn_MouseEnter;
            btnSignIn.MouseLeave += btnSignIn_MouseLeave;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(240, 706);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(687, 49);
            textPassword.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 661);
            label3.Name = "label3";
            label3.Size = new Size(134, 42);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(240, 559);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(687, 49);
            textUsername.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 514);
            label2.Name = "label2";
            label2.Size = new Size(142, 42);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 375);
            label1.Name = "label1";
            label1.Size = new Size(604, 127);
            label1.TabIndex = 11;
            label1.Text = "Welcome Back";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.Logo_NgopiSek_Brown_Version;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(240, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 80);
            panel4.TabIndex = 10;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pressRegister);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Name = "UCLogin";
            Size = new Size(1145, 1162);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pressRegister;
        private Label label4;
        private Button btnSignIn;
        private TextBox textPassword;
        private Label label3;
        private TextBox textUsername;
        private Label label2;
        private Label label1;
        private Panel panel4;
    }
}

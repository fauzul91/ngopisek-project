namespace NgopiSek_Project_PBO.Views
{
    partial class Login
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
            panel3 = new Panel();
            panel2 = new Panel();
            panelLogin = new Panel();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.SidePanel;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 1166);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Quotes;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(51, 476);
            panel3.Name = "panel3";
            panel3.Size = new Size(465, 215);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Logo_NgopiSek;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(51, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 80);
            panel2.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.Dock = DockStyle.Right;
            panelLogin.Location = new Point(753, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1145, 1166);
            panelLogin.TabIndex = 3;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1166);
            Controls.Add(panelLogin);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panelLogin;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
    }
}
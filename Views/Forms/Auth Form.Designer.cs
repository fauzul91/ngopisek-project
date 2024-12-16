namespace NgopiSek_Desktop_App_V2
{
    partial class Authentication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelAuth = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Side_Login_Panel;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 1166);
            panel1.TabIndex = 0;
            // 
            // panelAuth
            // 
            panelAuth.BackColor = Color.FromArgb(246, 246, 246);
            panelAuth.Dock = DockStyle.Right;
            panelAuth.Location = new Point(747, 0);
            panelAuth.Name = "panelAuth";
            panelAuth.Size = new Size(1147, 1166);
            panelAuth.TabIndex = 1;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1166);
            Controls.Add(panelAuth);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Authentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auth";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelAuth;
    }
}

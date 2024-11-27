namespace NgopiSek_Project_PBO
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            loadingBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Logo_NgopiSek_Splash_Screen;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(531, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 375);
            panel1.TabIndex = 0;
            // 
            // loadingBar
            // 
            loadingBar.BackColor = Color.FromArgb(255, 192, 128);
            loadingBar.Location = new Point(391, 850);
            loadingBar.Name = "loadingBar";
            loadingBar.Size = new Size(1106, 39);
            loadingBar.Style = ProgressBarStyle.Marquee;
            loadingBar.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Panel;
            ClientSize = new Size(1898, 1166);
            Controls.Add(loadingBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NgopiSek";
            Load += SplashScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ProgressBar loadingBar;
        private System.Windows.Forms.Timer timer1;
    }
}

namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    partial class DetailPesanan
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
            panel2 = new Panel();
            flowDetailsOrder = new FlowLayoutPanel();
            panel3 = new Panel();
            textSubTotal = new Label();
            textTax = new Label();
            textTotalAmount = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Order_Title;
            panel1.Location = new Point(46, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 76);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Order_Table;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(flowDetailsOrder);
            panel2.Location = new Point(42, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 481);
            panel2.TabIndex = 1;
            // 
            // flowDetailsOrder
            // 
            flowDetailsOrder.AutoScroll = true;
            flowDetailsOrder.BackColor = Color.Transparent;
            flowDetailsOrder.Location = new Point(20, 60);
            flowDetailsOrder.Name = "flowDetailsOrder";
            flowDetailsOrder.Size = new Size(567, 386);
            flowDetailsOrder.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Payment_Summary;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(50, 686);
            panel3.Name = "panel3";
            panel3.Size = new Size(202, 168);
            panel3.TabIndex = 2;
            // 
            // textSubTotal
            // 
            textSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSubTotal.AutoSize = true;
            textSubTotal.Font = new Font("Gilroy-Bold", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSubTotal.ForeColor = Color.FromArgb(53, 53, 53);
            textSubTotal.Location = new Point(532, 745);
            textSubTotal.Name = "textSubTotal";
            textSubTotal.Size = new Size(43, 20);
            textSubTotal.TabIndex = 6;
            textSubTotal.Text = "Rp 0";
            textSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textTax
            // 
            textTax.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTax.AutoSize = true;
            textTax.Font = new Font("Gilroy-Bold", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTax.ForeColor = Color.FromArgb(53, 53, 53);
            textTax.Location = new Point(532, 785);
            textTax.Name = "textTax";
            textTax.Size = new Size(43, 20);
            textTax.TabIndex = 7;
            textTax.Text = "Rp 0";
            textTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textTotalAmount
            // 
            textTotalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTotalAmount.AutoSize = true;
            textTotalAmount.Font = new Font("Gilroy-Bold", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTotalAmount.ForeColor = Color.FromArgb(53, 53, 53);
            textTotalAmount.Location = new Point(530, 827);
            textTotalAmount.Name = "textTotalAmount";
            textTotalAmount.Size = new Size(60, 28);
            textTotalAmount.TabIndex = 8;
            textTotalAmount.Text = "Rp 0";
            textTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DetailPesanan
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(698, 989);
            Controls.Add(textTotalAmount);
            Controls.Add(textTax);
            Controls.Add(textSubTotal);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "DetailPesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailPesanan";
            TransparencyKey = Color.Blue;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowDetailsOrder;
        private Panel panel3;
        private Label textSubTotal;
        private Label textTax;
        private Label textTotalAmount;
    }
}
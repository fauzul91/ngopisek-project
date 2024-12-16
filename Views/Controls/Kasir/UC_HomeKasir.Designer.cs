namespace NgopiSek_Desktop_App_V2.Views.Controls.Kasir
{
    partial class UC_HomeKasir
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
            catPanel = new FlowLayoutPanel();
            productPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            searchBar = new Panel();
            textSearch = new TextBox();
            searchIcon = new Button();
            btnCheckOut = new Button();
            flowPaymentMethod = new FlowLayoutPanel();
            panel6 = new Panel();
            flowOrderDetails = new FlowLayoutPanel();
            panel5 = new Panel();
            panel3 = new Panel();
            textCustomerName = new TextBox();
            panel2 = new Panel();
            textTotal = new Label();
            textTax = new Label();
            textSubTotal = new Label();
            panelTransaksi = new Panel();
            flowOrderMethod = new FlowLayoutPanel();
            searchBar.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelTransaksi.SuspendLayout();
            SuspendLayout();
            // 
            // catPanel
            // 
            catPanel.AutoScroll = true;
            catPanel.BackColor = SystemColors.ButtonHighlight;
            catPanel.Location = new Point(0, 125);
            catPanel.Name = "catPanel";
            catPanel.Padding = new Padding(33, 0, 0, 0);
            catPanel.Size = new Size(1256, 150);
            catPanel.TabIndex = 0;
            // 
            // productPanel
            // 
            productPanel.AutoScroll = true;
            productPanel.BackColor = SystemColors.ButtonHighlight;
            productPanel.Location = new Point(3, 375);
            productPanel.Name = "productPanel";
            productPanel.Padding = new Padding(50, 0, 0, 0);
            productPanel.Size = new Size(1253, 791);
            productPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.NgopiSek_Menu_Text;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(63, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 51);
            panel1.TabIndex = 0;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BackgroundImage = Properties.Resources.Top_Bar3;
            searchBar.BackgroundImageLayout = ImageLayout.Stretch;
            searchBar.Controls.Add(textSearch);
            searchBar.Controls.Add(searchIcon);
            searchBar.Location = new Point(0, 0);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(1256, 123);
            searchBar.TabIndex = 3;
            // 
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.None;
            textSearch.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.ForeColor = Color.FromArgb(53, 53, 53);
            textSearch.Location = new Point(522, 41);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(464, 25);
            textSearch.TabIndex = 4;
            // 
            // searchIcon
            // 
            searchIcon.BackColor = Color.White;
            searchIcon.FlatAppearance.BorderSize = 0;
            searchIcon.FlatStyle = FlatStyle.Flat;
            searchIcon.Image = Properties.Resources.Search_Icon;
            searchIcon.Location = new Point(472, 34);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(41, 39);
            searchIcon.TabIndex = 3;
            searchIcon.UseVisualStyleBackColor = false;
            searchIcon.Click += searchIcon_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(255, 145, 83);
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Gilroy-Bold", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(30, 1012);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(412, 61);
            btnCheckOut.TabIndex = 11;
            btnCheckOut.Text = "Checkout";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // flowPaymentMethod
            // 
            flowPaymentMethod.AutoScroll = true;
            flowPaymentMethod.BackColor = Color.Transparent;
            flowPaymentMethod.BackgroundImage = Properties.Resources.Background_Payment_Method;
            flowPaymentMethod.Location = new Point(30, 725);
            flowPaymentMethod.Name = "flowPaymentMethod";
            flowPaymentMethod.Size = new Size(412, 96);
            flowPaymentMethod.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Order_Details;
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Location = new Point(30, 273);
            panel6.Name = "panel6";
            panel6.Size = new Size(181, 32);
            panel6.TabIndex = 7;
            // 
            // flowOrderDetails
            // 
            flowOrderDetails.AutoScroll = true;
            flowOrderDetails.BackColor = Color.Transparent;
            flowOrderDetails.BackgroundImage = Properties.Resources.Background_Order_Details;
            flowOrderDetails.BackgroundImageLayout = ImageLayout.Stretch;
            flowOrderDetails.ForeColor = Color.FromArgb(53, 53, 53);
            flowOrderDetails.Location = new Point(30, 311);
            flowOrderDetails.Name = "flowOrderDetails";
            flowOrderDetails.Padding = new Padding(25, 0, 25, 0);
            flowOrderDetails.Size = new Size(412, 396);
            flowOrderDetails.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.Order_Summary;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Location = new Point(30, 839);
            panel5.Name = "panel5";
            panel5.Size = new Size(214, 32);
            panel5.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Customer_Name;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(textCustomerName);
            panel3.Location = new Point(30, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 107);
            panel3.TabIndex = 6;
            // 
            // textCustomerName
            // 
            textCustomerName.BorderStyle = BorderStyle.None;
            textCustomerName.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCustomerName.ForeColor = Color.FromArgb(53, 53, 53);
            textCustomerName.Location = new Point(17, 57);
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new Size(368, 25);
            textCustomerName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.Summary;
            panel2.Controls.Add(textTotal);
            panel2.Controls.Add(textTax);
            panel2.Controls.Add(textSubTotal);
            panel2.Location = new Point(30, 877);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 112);
            panel2.TabIndex = 13;
            // 
            // textTotal
            // 
            textTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTotal.AutoSize = true;
            textTotal.Font = new Font("Gilroy-SemiBold", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTotal.ForeColor = Color.FromArgb(53, 53, 53);
            textTotal.Location = new Point(311, 74);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(43, 20);
            textTotal.TabIndex = 2;
            textTotal.Text = "Rp 0";
            textTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textTax
            // 
            textTax.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTax.AutoSize = true;
            textTax.Font = new Font("Gilroy-SemiBold", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTax.ForeColor = Color.FromArgb(53, 53, 53);
            textTax.Location = new Point(311, 46);
            textTax.Name = "textTax";
            textTax.Size = new Size(43, 20);
            textTax.TabIndex = 1;
            textTax.Text = "Rp 0";
            textTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textSubTotal
            // 
            textSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSubTotal.AutoSize = true;
            textSubTotal.Font = new Font("Gilroy-SemiBold", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSubTotal.ForeColor = Color.FromArgb(53, 53, 53);
            textSubTotal.Location = new Point(311, 17);
            textSubTotal.Name = "textSubTotal";
            textSubTotal.Size = new Size(43, 20);
            textSubTotal.TabIndex = 0;
            textSubTotal.Text = "Rp 0";
            textSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelTransaksi
            // 
            panelTransaksi.BackColor = Color.White;
            panelTransaksi.BackgroundImageLayout = ImageLayout.Zoom;
            panelTransaksi.Controls.Add(flowOrderMethod);
            panelTransaksi.Controls.Add(panel2);
            panelTransaksi.Controls.Add(panel3);
            panelTransaksi.Controls.Add(panel5);
            panelTransaksi.Controls.Add(flowOrderDetails);
            panelTransaksi.Controls.Add(panel6);
            panelTransaksi.Controls.Add(flowPaymentMethod);
            panelTransaksi.Controls.Add(btnCheckOut);
            panelTransaksi.Dock = DockStyle.Right;
            panelTransaksi.Location = new Point(1257, 0);
            panelTransaksi.Name = "panelTransaksi";
            panelTransaksi.Size = new Size(473, 1174);
            panelTransaksi.TabIndex = 4;
            // 
            // flowOrderMethod
            // 
            flowOrderMethod.AutoScroll = true;
            flowOrderMethod.BackColor = Color.Transparent;
            flowOrderMethod.BackgroundImage = Properties.Resources.Background_Payment_Method;
            flowOrderMethod.Location = new Point(30, 15);
            flowOrderMethod.Name = "flowOrderMethod";
            flowOrderMethod.Size = new Size(412, 96);
            flowOrderMethod.TabIndex = 14;
            // 
            // UC_HomeKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(panelTransaksi);
            Controls.Add(searchBar);
            Controls.Add(panel1);
            Controls.Add(productPanel);
            Controls.Add(catPanel);
            Name = "UC_HomeKasir";
            Size = new Size(1730, 1174);
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelTransaksi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel catPanel;
        private FlowLayoutPanel productPanel;
        private Panel panel1;
        private Panel searchBar;
        private TextBox textSearch;
        private Button searchIcon;
        private Button btnCheckOut;
        private FlowLayoutPanel flowPaymentMethod;
        private Panel panel6;
        private FlowLayoutPanel flowOrderDetails;
        private Panel panel5;
        private Panel panel3;
        private TextBox textCustomerName;
        private Panel panel2;
        private Label textTotal;
        private Label textTax;
        private Label textSubTotal;
        private Panel panelTransaksi;
        private FlowLayoutPanel flowOrderMethod;
    }
}

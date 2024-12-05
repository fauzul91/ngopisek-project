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
            panelTransaksi = new Panel();
            panel3 = new Panel();
            textCustomerName = new TextBox();
            panel4 = new Panel();
            textTotal = new Label();
            textTax = new Label();
            textSubTotal = new Label();
            panel5 = new Panel();
            flowOrderDetails = new FlowLayoutPanel();
            panel6 = new Panel();
            flowPaymentMethod = new FlowLayoutPanel();
            btnCheckOut = new Button();
            searchBar.SuspendLayout();
            panelTransaksi.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // catPanel
            // 
            catPanel.AutoScroll = true;
            catPanel.Location = new Point(0, 125);
            catPanel.Name = "catPanel";
            catPanel.Padding = new Padding(33, 0, 0, 0);
            catPanel.Size = new Size(1272, 150);
            catPanel.TabIndex = 0;
            // 
            // productPanel
            // 
            productPanel.AutoScroll = true;
            productPanel.Location = new Point(3, 375);
            productPanel.Name = "productPanel";
            productPanel.Padding = new Padding(50, 0, 0, 0);
            productPanel.Size = new Size(1269, 791);
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
            searchBar.Size = new Size(1272, 123);
            searchBar.TabIndex = 3;
            // 
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.None;
            textSearch.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.ForeColor = Color.FromArgb(53, 53, 53);
            textSearch.Location = new Point(534, 47);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(491, 25);
            textSearch.TabIndex = 4;
            // 
            // searchIcon
            // 
            searchIcon.BackColor = Color.White;
            searchIcon.FlatAppearance.BorderSize = 0;
            searchIcon.FlatStyle = FlatStyle.Flat;
            searchIcon.Image = Properties.Resources.Search_Icon;
            searchIcon.Location = new Point(478, 39);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(41, 39);
            searchIcon.TabIndex = 3;
            searchIcon.UseVisualStyleBackColor = false;
            searchIcon.Click += searchIcon_Click;
            // 
            // panelTransaksi
            // 
            panelTransaksi.Controls.Add(panel3);
            panelTransaksi.Controls.Add(panel4);
            panelTransaksi.Controls.Add(panel5);
            panelTransaksi.Controls.Add(flowOrderDetails);
            panelTransaksi.Controls.Add(panel6);
            panelTransaksi.Controls.Add(flowPaymentMethod);
            panelTransaksi.Controls.Add(btnCheckOut);
            panelTransaksi.Dock = DockStyle.Right;
            panelTransaksi.Location = new Point(1278, 0);
            panelTransaksi.Name = "panelTransaksi";
            panelTransaksi.Size = new Size(452, 1174);
            panelTransaksi.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Cust_Information;
            panel3.Controls.Add(textCustomerName);
            panel3.Location = new Point(13, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 169);
            panel3.TabIndex = 6;
            // 
            // textCustomerName
            // 
            textCustomerName.BorderStyle = BorderStyle.None;
            textCustomerName.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCustomerName.ForeColor = Color.FromArgb(53, 53, 53);
            textCustomerName.Location = new Point(15, 124);
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new Size(377, 25);
            textCustomerName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Summary;
            panel4.Controls.Add(textTotal);
            panel4.Controls.Add(textTax);
            panel4.Controls.Add(textSubTotal);
            panel4.Location = new Point(13, 907);
            panel4.Name = "panel4";
            panel4.Size = new Size(412, 112);
            panel4.TabIndex = 10;
            // 
            // textTotal
            // 
            textTotal.Anchor = AnchorStyles.Right;
            textTotal.AutoSize = true;
            textTotal.Font = new Font("Gilroy-Medium", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTotal.Location = new Point(569, 85);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(45, 19);
            textTotal.TabIndex = 2;
            textTotal.Text = "total";
            textTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textTax
            // 
            textTax.Anchor = AnchorStyles.Right;
            textTax.AutoSize = true;
            textTax.Font = new Font("Gilroy-Medium", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTax.Location = new Point(583, 54);
            textTax.Name = "textTax";
            textTax.Size = new Size(33, 19);
            textTax.TabIndex = 1;
            textTax.Text = "tax";
            textTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textSubTotal
            // 
            textSubTotal.Anchor = AnchorStyles.Right;
            textSubTotal.AutoSize = true;
            textSubTotal.Font = new Font("Gilroy-Medium", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSubTotal.Location = new Point(545, 24);
            textSubTotal.Name = "textSubTotal";
            textSubTotal.Size = new Size(71, 19);
            textSubTotal.TabIndex = 0;
            textSubTotal.Text = "subtotal";
            textSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.Order_Summary;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Location = new Point(13, 869);
            panel5.Name = "panel5";
            panel5.Size = new Size(214, 32);
            panel5.TabIndex = 8;
            // 
            // flowOrderDetails
            // 
            flowOrderDetails.Location = new Point(13, 294);
            flowOrderDetails.Name = "flowOrderDetails";
            flowOrderDetails.Size = new Size(412, 378);
            flowOrderDetails.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Order_Details;
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Location = new Point(13, 247);
            panel6.Name = "panel6";
            panel6.Size = new Size(181, 32);
            panel6.TabIndex = 7;
            // 
            // flowPaymentMethod
            // 
            flowPaymentMethod.Location = new Point(13, 693);
            flowPaymentMethod.Name = "flowPaymentMethod";
            flowPaymentMethod.Size = new Size(412, 145);
            flowPaymentMethod.TabIndex = 12;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(255, 145, 83);
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Gilroy-Bold", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(13, 1058);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(412, 61);
            btnCheckOut.TabIndex = 11;
            btnCheckOut.Text = "Checkout";
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // UC_HomeKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panelTransaksi);
            Controls.Add(searchBar);
            Controls.Add(panel1);
            Controls.Add(productPanel);
            Controls.Add(catPanel);
            Name = "UC_HomeKasir";
            Size = new Size(1730, 1174);
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            panelTransaksi.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel catPanel;
        private FlowLayoutPanel productPanel;
        private Panel panel1;
        private Panel searchBar;
        private TextBox textSearch;
        private Button searchIcon;
        private Panel panelTransaksi;
        private Panel panel3;
        private TextBox textCustomerName;
        private Panel panel4;
        private Label textTotal;
        private Label textTax;
        private Label textSubTotal;
        private Panel panel5;
        private FlowLayoutPanel flowOrderDetails;
        private Panel panel6;
        private FlowLayoutPanel flowPaymentMethod;
        private Button btnCheckOut;
    }
}

namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    partial class UCHome
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataRevenue = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dataCustomers = new Label();
            panel3 = new Panel();
            dataProducts = new Label();
            label1 = new Label();
            panel4 = new Panel();
            dataGridRecentInvoice = new DataGridView();
            panel5 = new Panel();
            flowTop5Products = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRecentInvoice).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Total_Revenue;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(dataRevenue);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(50, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 273);
            panel1.TabIndex = 0;
            // 
            // dataRevenue
            // 
            dataRevenue.AutoSize = true;
            dataRevenue.BackColor = Color.Transparent;
            dataRevenue.Font = new Font("Gilroy-Bold", 21.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataRevenue.Location = new Point(160, 143);
            dataRevenue.Name = "dataRevenue";
            dataRevenue.Size = new Size(198, 54);
            dataRevenue.TabIndex = 1;
            dataRevenue.Text = "1250000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gilroy-Light", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 143);
            label2.Name = "label2";
            label2.Size = new Size(78, 53);
            label2.TabIndex = 0;
            label2.Text = "Rp";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Total_Customer;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(dataCustomers);
            panel2.Location = new Point(525, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 273);
            panel2.TabIndex = 1;
            // 
            // dataCustomers
            // 
            dataCustomers.AutoSize = true;
            dataCustomers.BackColor = Color.Transparent;
            dataCustomers.Font = new Font("Gilroy-Bold", 21.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataCustomers.Location = new Point(156, 142);
            dataCustomers.Name = "dataCustomers";
            dataCustomers.Size = new Size(71, 54);
            dataCustomers.TabIndex = 2;
            dataCustomers.Text = "70";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Total_Products;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(dataProducts);
            panel3.Location = new Point(1000, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 273);
            panel3.TabIndex = 2;
            // 
            // dataProducts
            // 
            dataProducts.AutoSize = true;
            dataProducts.BackColor = Color.Transparent;
            dataProducts.Font = new Font("Gilroy-Bold", 21.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataProducts.Location = new Point(164, 142);
            dataProducts.Name = "dataProducts";
            dataProducts.Size = new Size(91, 54);
            dataProducts.TabIndex = 3;
            dataProducts.Text = "120";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gilroy-SemiBold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 72);
            label1.Name = "label1";
            label1.Size = new Size(269, 44);
            label1.TabIndex = 3;
            label1.Text = "Welcome Back";
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Recent_Invoice;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(dataGridRecentInvoice);
            panel4.Location = new Point(58, 436);
            panel4.Name = "panel4";
            panel4.Size = new Size(925, 670);
            panel4.TabIndex = 1;
            // 
            // dataGridRecentInvoice
            // 
            dataGridRecentInvoice.AllowUserToOrderColumns = true;
            dataGridRecentInvoice.AllowUserToResizeColumns = false;
            dataGridRecentInvoice.AllowUserToResizeRows = false;
            dataGridRecentInvoice.BackgroundColor = Color.White;
            dataGridRecentInvoice.BorderStyle = BorderStyle.None;
            dataGridRecentInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridRecentInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gilroy-Medium", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridRecentInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridRecentInvoice.ColumnHeadersHeight = 75;
            dataGridRecentInvoice.EnableHeadersVisualStyles = false;
            dataGridRecentInvoice.GridColor = Color.White;
            dataGridRecentInvoice.Location = new Point(93, 143);
            dataGridRecentInvoice.Name = "dataGridRecentInvoice";
            dataGridRecentInvoice.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gilroy-Regular", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridRecentInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridRecentInvoice.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Gilroy-Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridRecentInvoice.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridRecentInvoice.RowTemplate.Height = 50;
            dataGridRecentInvoice.ScrollBars = ScrollBars.Vertical;
            dataGridRecentInvoice.Size = new Size(769, 456);
            dataGridRecentInvoice.TabIndex = 9;
            dataGridRecentInvoice.CellContentClick += dataGridRecentInvoice_CellContentClick;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Top_5_Products;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Controls.Add(flowTop5Products);
            panel5.Location = new Point(1000, 436);
            panel5.Name = "panel5";
            panel5.Size = new Size(469, 670);
            panel5.TabIndex = 3;
            // 
            // flowTop5Products
            // 
            flowTop5Products.AutoScroll = true;
            flowTop5Products.BackColor = Color.White;
            flowTop5Products.Location = new Point(59, 143);
            flowTop5Products.Name = "flowTop5Products";
            flowTop5Products.Size = new Size(345, 456);
            flowTop5Products.TabIndex = 2;
            // 
            // UCHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCHome";
            Size = new Size(1510, 1166);
            Load += UCHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridRecentInvoice).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Label dataRevenue;
        private Label dataCustomers;
        private Label dataProducts;
        private FlowLayoutPanel flowTop5Products;
        private DataGridView dataGridRecentInvoice;
    }
}

namespace NgopiSek_Desktop_App_V2.Views.Controls.Kasir
{
    partial class UC_HistoryPesanan
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
            searchBar = new Panel();
            searchIcon = new Button();
            textSearch = new TextBox();
            dataGridHistoryOrder = new DataGridView();
            searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHistoryOrder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Pesanan;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(65, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 57);
            panel1.TabIndex = 11;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BackgroundImage = Properties.Resources.Search_Bar;
            searchBar.BackgroundImageLayout = ImageLayout.Stretch;
            searchBar.Controls.Add(searchIcon);
            searchBar.Controls.Add(textSearch);
            searchBar.Location = new Point(65, 82);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(748, 85);
            searchBar.TabIndex = 10;
            // 
            // searchIcon
            // 
            searchIcon.BackColor = Color.Transparent;
            searchIcon.FlatAppearance.BorderSize = 0;
            searchIcon.FlatStyle = FlatStyle.Flat;
            searchIcon.Image = Properties.Resources.Search_Icon;
            searchIcon.Location = new Point(22, 16);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(54, 45);
            searchIcon.TabIndex = 3;
            searchIcon.UseVisualStyleBackColor = false;
            searchIcon.Click += searchIcon_Click;
            // 
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.None;
            textSearch.Cursor = Cursors.IBeam;
            textSearch.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.Location = new Point(85, 24);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(611, 30);
            textSearch.TabIndex = 0;
            // 
            // dataGridHistoryOrder
            // 
            dataGridHistoryOrder.AllowUserToOrderColumns = true;
            dataGridHistoryOrder.AllowUserToResizeColumns = false;
            dataGridHistoryOrder.AllowUserToResizeRows = false;
            dataGridHistoryOrder.BackgroundColor = Color.White;
            dataGridHistoryOrder.BorderStyle = BorderStyle.Fixed3D;
            dataGridHistoryOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridHistoryOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridHistoryOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridHistoryOrder.ColumnHeadersHeight = 75;
            dataGridHistoryOrder.EnableHeadersVisualStyles = false;
            dataGridHistoryOrder.GridColor = Color.White;
            dataGridHistoryOrder.Location = new Point(65, 350);
            dataGridHistoryOrder.Name = "dataGridHistoryOrder";
            dataGridHistoryOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gilroy-Regular", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridHistoryOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridHistoryOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridHistoryOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridHistoryOrder.RowTemplate.Height = 50;
            dataGridHistoryOrder.ScrollBars = ScrollBars.Vertical;
            dataGridHistoryOrder.Size = new Size(1559, 743);
            dataGridHistoryOrder.TabIndex = 12;
            dataGridHistoryOrder.CellContentClick += dataGridHistoryOrder_CellContentClick;
            // 
            // UC_HistoryPesanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            Controls.Add(panel1);
            Controls.Add(searchBar);
            Controls.Add(dataGridHistoryOrder);
            Name = "UC_HistoryPesanan";
            Size = new Size(1730, 1174);
            Load += UC_HistoryPesanan_Load;
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHistoryOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel searchBar;
        private Button searchIcon;
        private TextBox textSearch;
        private DataGridView dataGridHistoryOrder;
    }
}

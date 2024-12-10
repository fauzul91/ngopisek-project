namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    partial class UCOrder
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
            textSearch = new TextBox();
            dataGridOrder = new DataGridView();
            searchIcon = new Button();
            searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Pesanan;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(89, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 57);
            panel1.TabIndex = 5;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BackgroundImage = Properties.Resources.Search_Bar;
            searchBar.BackgroundImageLayout = ImageLayout.Stretch;
            searchBar.Controls.Add(searchIcon);
            searchBar.Controls.Add(textSearch);
            searchBar.Location = new Point(89, 78);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(748, 85);
            searchBar.TabIndex = 4;
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
            // dataGridOrder
            // 
            dataGridOrder.AllowUserToOrderColumns = true;
            dataGridOrder.AllowUserToResizeColumns = false;
            dataGridOrder.AllowUserToResizeRows = false;
            dataGridOrder.BackgroundColor = Color.White;
            dataGridOrder.BorderStyle = BorderStyle.None;
            dataGridOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridOrder.ColumnHeadersHeight = 75;
            dataGridOrder.EnableHeadersVisualStyles = false;
            dataGridOrder.GridColor = Color.White;
            dataGridOrder.Location = new Point(89, 346);
            dataGridOrder.Name = "dataGridOrder";
            dataGridOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gilroy-Regular", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridOrder.RowTemplate.Height = 50;
            dataGridOrder.ScrollBars = ScrollBars.Vertical;
            dataGridOrder.Size = new Size(1333, 743);
            dataGridOrder.TabIndex = 9;
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
            searchIcon.Click += searchIcon_Click_1;
            // 
            // UCOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridOrder);
            Controls.Add(panel1);
            Controls.Add(searchBar);
            Name = "UCOrder";
            Size = new Size(1510, 1166);
            Load += UCOrder_Load;
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel searchBar;
        private TextBox textSearch;
        private DataGridView dataGridOrder;
        private Button searchIcon;
    }
}

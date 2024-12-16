namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    partial class UCProduct
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
            searchBar = new Panel();
            searchIcon = new Button();
            textSearch = new TextBox();
            panel1 = new Panel();
            dataGridProduct = new DataGridView();
            btnAddProduct = new Button();
            searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).BeginInit();
            SuspendLayout();
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
            searchBar.TabIndex = 0;
            // 
            // searchIcon
            // 
            searchIcon.BackColor = Color.Transparent;
            searchIcon.FlatAppearance.BorderSize = 0;
            searchIcon.FlatStyle = FlatStyle.Flat;
            searchIcon.Image = Properties.Resources.Search_Icon;
            searchIcon.Location = new Point(22, 14);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(54, 45);
            searchIcon.TabIndex = 2;
            searchIcon.UseVisualStyleBackColor = false;
            searchIcon.Click += searchIcon_Click;
            // 
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.None;
            textSearch.Cursor = Cursors.IBeam;
            textSearch.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.Location = new Point(86, 24);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(611, 30);
            textSearch.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Product;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(89, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 59);
            panel1.TabIndex = 1;
            // 
            // dataGridProduct
            // 
            dataGridProduct.AllowUserToOrderColumns = true;
            dataGridProduct.AllowUserToResizeColumns = false;
            dataGridProduct.AllowUserToResizeRows = false;
            dataGridProduct.BackgroundColor = Color.White;
            dataGridProduct.BorderStyle = BorderStyle.None;
            dataGridProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProduct.ColumnHeadersHeight = 75;
            dataGridProduct.EnableHeadersVisualStyles = false;
            dataGridProduct.GridColor = Color.White;
            dataGridProduct.Location = new Point(89, 346);
            dataGridProduct.Name = "dataGridProduct";
            dataGridProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gilroy-Regular", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridProduct.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridProduct.RowTemplate.Height = 50;
            dataGridProduct.ScrollBars = ScrollBars.Vertical;
            dataGridProduct.Size = new Size(1333, 743);
            dataGridProduct.TabIndex = 2;
            dataGridProduct.CellContentClick += dataGridProduct_CellContentClick;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(255, 145, 83);
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Image = Properties.Resources.Add_Icon;
            btnAddProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProduct.Location = new Point(1147, 233);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Padding = new Padding(20, 0, 0, 0);
            btnAddProduct.Size = new Size(275, 72);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "  Add new product";
            btnAddProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // UCProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            Controls.Add(btnAddProduct);
            Controls.Add(dataGridProduct);
            Controls.Add(panel1);
            Controls.Add(searchBar);
            Name = "UCProduct";
            Size = new Size(1510, 1166);
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel searchBar;
        private Panel panel1;
        private DataGridView dataGridProduct;
        private Button btnAddProduct;
        private TextBox textSearch;
        private Button searchIcon;
    }
}

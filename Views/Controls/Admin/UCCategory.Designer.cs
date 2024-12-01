namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    partial class UCCategory
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
            btnAddCategory = new Button();
            dataGridCategory = new DataGridView();
            searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Kategori;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(89, 248);
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
            // searchIcon
            // 
            searchIcon.BackColor = Color.Transparent;
            searchIcon.FlatAppearance.BorderSize = 0;
            searchIcon.FlatStyle = FlatStyle.Flat;
            searchIcon.Image = Properties.Resources.Search_Icon;
            searchIcon.Location = new Point(22, 14);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(54, 45);
            searchIcon.TabIndex = 1;
            searchIcon.UseVisualStyleBackColor = false;
            searchIcon.Click += searchIcon_Click;
            // 
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.None;
            textSearch.Cursor = Cursors.IBeam;
            textSearch.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.Location = new Point(87, 24);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(611, 30);
            textSearch.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.FromArgb(255, 145, 83);
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Image = Properties.Resources.Add_Icon;
            btnAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCategory.Location = new Point(1147, 233);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Padding = new Padding(15, 0, 0, 0);
            btnAddCategory.Size = new Size(275, 72);
            btnAddCategory.TabIndex = 7;
            btnAddCategory.Text = "  Add new category";
            btnAddCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // dataGridCategory
            // 
            dataGridCategory.AllowUserToOrderColumns = true;
            dataGridCategory.AllowUserToResizeColumns = false;
            dataGridCategory.AllowUserToResizeRows = false;
            dataGridCategory.BackgroundColor = Color.White;
            dataGridCategory.BorderStyle = BorderStyle.None;
            dataGridCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCategory.ColumnHeadersHeight = 75;
            dataGridCategory.EnableHeadersVisualStyles = false;
            dataGridCategory.GridColor = Color.White;
            dataGridCategory.Location = new Point(89, 346);
            dataGridCategory.Name = "dataGridCategory";
            dataGridCategory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gilroy-Regular", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridCategory.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCategory.RowTemplate.Height = 50;
            dataGridCategory.ScrollBars = ScrollBars.Vertical;
            dataGridCategory.Size = new Size(1333, 743);
            dataGridCategory.TabIndex = 8;
            dataGridCategory.CellContentClick += dataGridCategory_CellContentClick_1;
            // 
            // UCCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridCategory);
            Controls.Add(btnAddCategory);
            Controls.Add(panel1);
            Controls.Add(searchBar);
            Name = "UCCategory";
            Size = new Size(1510, 1166);
            Load += UCCategory_Load;
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel searchBar;
        private TextBox textSearch;
        private Button btnAddCategory;
        private DataGridView dataGridCategory;
        private Button searchIcon;
    }
}

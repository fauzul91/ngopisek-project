namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    partial class UCPayment
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
            btnAddPayment = new Button();
            dataGridPayment = new DataGridView();
            panel1 = new Panel();
            searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPayment).BeginInit();
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
            // btnAddPayment
            // 
            btnAddPayment.BackColor = Color.FromArgb(255, 145, 83);
            btnAddPayment.FlatAppearance.BorderSize = 0;
            btnAddPayment.FlatStyle = FlatStyle.Flat;
            btnAddPayment.Font = new Font("Gilroy-SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPayment.ForeColor = Color.White;
            btnAddPayment.Image = Properties.Resources.Add_Icon;
            btnAddPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddPayment.Location = new Point(1147, 233);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Padding = new Padding(20, 0, 0, 0);
            btnAddPayment.Size = new Size(275, 72);
            btnAddPayment.TabIndex = 7;
            btnAddPayment.Text = "  Add new payment";
            btnAddPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddPayment.UseVisualStyleBackColor = false;
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // dataGridPayment
            // 
            dataGridPayment.AllowUserToOrderColumns = true;
            dataGridPayment.AllowUserToResizeColumns = false;
            dataGridPayment.AllowUserToResizeRows = false;
            dataGridPayment.BackgroundColor = Color.White;
            dataGridPayment.BorderStyle = BorderStyle.None;
            dataGridPayment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridPayment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPayment.ColumnHeadersHeight = 75;
            dataGridPayment.EnableHeadersVisualStyles = false;
            dataGridPayment.GridColor = Color.White;
            dataGridPayment.Location = new Point(89, 346);
            dataGridPayment.Name = "dataGridPayment";
            dataGridPayment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gilroy-Regular", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPayment.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridPayment.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridPayment.RowTemplate.Height = 50;
            dataGridPayment.ScrollBars = ScrollBars.Vertical;
            dataGridPayment.Size = new Size(1333, 743);
            dataGridPayment.TabIndex = 6;
            dataGridPayment.CellContentClick += dataGridPayment_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Metode_Pembayaran;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(89, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 59);
            panel1.TabIndex = 5;
            // 
            // UCPayment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            Controls.Add(searchBar);
            Controls.Add(btnAddPayment);
            Controls.Add(dataGridPayment);
            Controls.Add(panel1);
            Name = "UCPayment";
            Size = new Size(1510, 1166);
            Load += UCPayment_Load;
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel searchBar;
        private Button searchIcon;
        private TextBox textSearch;
        private Button btnAddPayment;
        private DataGridView dataGridPayment;
        private Panel panel1;
    }
}

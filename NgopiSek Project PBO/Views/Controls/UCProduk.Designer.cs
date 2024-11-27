namespace NgopiSek_Project_PBO.Views.Controls
{
    partial class UCProduk
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridProduct = new DataGridView();
            label1 = new Label();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).BeginInit();
            SuspendLayout();
            // 
            // dataGridProduct
            // 
            dataGridProduct.AllowUserToOrderColumns = true;
            dataGridProduct.AllowUserToResizeColumns = false;
            dataGridProduct.AllowUserToResizeRows = false;
            dataGridProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridProduct.BackgroundColor = Color.White;
            dataGridProduct.BorderStyle = BorderStyle.None;
            dataGridProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(186, 115, 55);
            dataGridViewCellStyle1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(186, 115, 55);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridProduct.EnableHeadersVisualStyles = false;
            dataGridProduct.GridColor = Color.White;
            dataGridProduct.Location = new Point(104, 260);
            dataGridProduct.Name = "dataGridProduct";
            dataGridProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridProduct.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridProduct.Size = new Size(1226, 833);
            dataGridProduct.TabIndex = 0;
            dataGridProduct.CellContentClick += dataGridProduct_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 105);
            label1.Name = "label1";
            label1.Size = new Size(347, 127);
            label1.TabIndex = 28;
            label1.Text = "Product";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.White;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambah.Location = new Point(1114, 139);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(216, 56);
            btnTambah.TabIndex = 29;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // UCProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTambah);
            Controls.Add(label1);
            Controls.Add(dataGridProduct);
            Name = "UCProduk";
            Size = new Size(1452, 1166);
            Load += UCProduk_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridProduct;
        private Label label1;
        private Button btnTambah;
    }
}

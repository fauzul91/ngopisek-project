namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    partial class Product_Form
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
            btnCancel = new Button();
            btnAdd = new Button();
            textNamaProduk = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textHargaProduk = new TextBox();
            label3 = new Label();
            textStokProduk = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboKategori = new ComboBox();
            pressBrowse = new Label();
            label6 = new Label();
            pictureProduct = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(53, 53, 53);
            btnCancel.Location = new Point(915, 650);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(224, 61);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 145, 83);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(665, 650);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(224, 61);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textNamaProduk
            // 
            textNamaProduk.Font = new Font("Poppins", 14F);
            textNamaProduk.Location = new Point(665, 143);
            textNamaProduk.Name = "textNamaProduk";
            textNamaProduk.Size = new Size(474, 49);
            textNamaProduk.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gilroy-SemiBold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 33);
            label2.Name = "label2";
            label2.Size = new Size(229, 44);
            label2.TabIndex = 4;
            label2.Text = "Form Produk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gilroy-Medium", 12F);
            label1.Location = new Point(665, 111);
            label1.Name = "label1";
            label1.Size = new Size(161, 29);
            label1.TabIndex = 5;
            label1.Text = "Nama Produk";
            // 
            // textHargaProduk
            // 
            textHargaProduk.Font = new Font("Poppins", 14F);
            textHargaProduk.Location = new Point(665, 272);
            textHargaProduk.Name = "textHargaProduk";
            textHargaProduk.Size = new Size(474, 49);
            textHargaProduk.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gilroy-Medium", 12F);
            label3.Location = new Point(665, 231);
            label3.Name = "label3";
            label3.Size = new Size(163, 29);
            label3.TabIndex = 9;
            label3.Text = "Harga Produk";
            // 
            // textStokProduk
            // 
            textStokProduk.Font = new Font("Poppins", 14F);
            textStokProduk.Location = new Point(665, 409);
            textStokProduk.Name = "textStokProduk";
            textStokProduk.Size = new Size(474, 49);
            textStokProduk.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gilroy-Medium", 12F);
            label4.Location = new Point(665, 367);
            label4.Name = "label4";
            label4.Size = new Size(143, 29);
            label4.TabIndex = 11;
            label4.Text = "Stok Produk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gilroy-Medium", 12F);
            label5.Location = new Point(665, 500);
            label5.Name = "label5";
            label5.Size = new Size(177, 29);
            label5.TabIndex = 13;
            label5.Text = "Nama Kategori";
            // 
            // comboKategori
            // 
            comboKategori.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(665, 544);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(474, 58);
            comboKategori.TabIndex = 14;
            // 
            // pressBrowse
            // 
            pressBrowse.AutoSize = true;
            pressBrowse.Cursor = Cursors.Hand;
            pressBrowse.Font = new Font("Gilroy-ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pressBrowse.ForeColor = Color.FromArgb(255, 145, 83);
            pressBrowse.Location = new Point(239, 634);
            pressBrowse.Name = "pressBrowse";
            pressBrowse.Size = new Size(92, 30);
            pressBrowse.TabIndex = 16;
            pressBrowse.Text = "Browse";
            pressBrowse.Click += pressBrowse_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gilroy-Regular", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(326, 634);
            label6.Name = "label6";
            label6.Size = new Size(60, 29);
            label6.TabIndex = 17;
            label6.Text = "Files";
            // 
            // pictureProduct
            // 
            pictureProduct.BackColor = Color.White;
            pictureProduct.BackgroundImageLayout = ImageLayout.Stretch;
            pictureProduct.Location = new Point(92, 111);
            pictureProduct.Name = "pictureProduct";
            pictureProduct.Size = new Size(500, 500);
            pictureProduct.TabIndex = 18;
            pictureProduct.TabStop = false;
            // 
            // Product_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1251, 779);
            Controls.Add(pictureProduct);
            Controls.Add(label6);
            Controls.Add(pressBrowse);
            Controls.Add(comboKategori);
            Controls.Add(label5);
            Controls.Add(textStokProduk);
            Controls.Add(label4);
            Controls.Add(textHargaProduk);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textNamaProduk);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_Form";
            ((System.ComponentModel.ISupportInitialize)pictureProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox textNamaProduk;
        private Label label2;
        private Label label1;
        private TextBox textHargaProduk;
        private Label label3;
        private TextBox textStokProduk;
        private Label label4;
        private Label label5;
        private ComboBox comboKategori;
        private Label pressBrowse;
        private Label label6;
        private PictureBox pictureProduct;
    }
}
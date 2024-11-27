namespace NgopiSek_Project_PBO.Views.Forms
{
    partial class FormProduk
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
            label2 = new Label();
            textNamaProduk = new TextBox();
            textHargaProduk = new TextBox();
            label3 = new Label();
            textStokProduk = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboKategori = new ComboBox();
            btnSimpan = new Button();
            btnCancel = new Button();
            titleFormProduk = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 177);
            label2.Name = "label2";
            label2.Size = new Size(179, 42);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            // 
            // textNamaProduk
            // 
            textNamaProduk.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNamaProduk.Location = new Point(90, 222);
            textNamaProduk.Name = "textNamaProduk";
            textNamaProduk.Size = new Size(685, 55);
            textNamaProduk.TabIndex = 2;
            // 
            // textHargaProduk
            // 
            textHargaProduk.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textHargaProduk.Location = new Point(90, 353);
            textHargaProduk.Name = "textHargaProduk";
            textHargaProduk.Size = new Size(685, 55);
            textHargaProduk.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 308);
            label3.Name = "label3";
            label3.Size = new Size(179, 42);
            label3.TabIndex = 3;
            label3.Text = "Harga Produk";
            // 
            // textStokProduk
            // 
            textStokProduk.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textStokProduk.Location = new Point(90, 488);
            textStokProduk.Name = "textStokProduk";
            textStokProduk.Size = new Size(685, 55);
            textStokProduk.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 443);
            label4.Name = "label4";
            label4.Size = new Size(155, 42);
            label4.TabIndex = 5;
            label4.Text = "Stok Produk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(90, 583);
            label5.Name = "label5";
            label5.Size = new Size(118, 42);
            label5.TabIndex = 7;
            label5.Text = "Kategori";
            // 
            // comboKategori
            // 
            comboKategori.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(90, 628);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(685, 64);
            comboKategori.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(186, 115, 55);
            btnSimpan.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(93, 751);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(176, 56);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Save";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(288, 751);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(176, 56);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // titleFormProduk
            // 
            titleFormProduk.AutoSize = true;
            titleFormProduk.Font = new Font("Poppins SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleFormProduk.Location = new Point(71, 70);
            titleFormProduk.Name = "titleFormProduk";
            titleFormProduk.Size = new Size(343, 84);
            titleFormProduk.TabIndex = 0;
            titleFormProduk.Text = "Form Produk";
            // 
            // TambahProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1000, 900);
            Controls.Add(btnCancel);
            Controls.Add(btnSimpan);
            Controls.Add(comboKategori);
            Controls.Add(label5);
            Controls.Add(textStokProduk);
            Controls.Add(label4);
            Controls.Add(textHargaProduk);
            Controls.Add(label3);
            Controls.Add(textNamaProduk);
            Controls.Add(label2);
            Controls.Add(titleFormProduk);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textNamaProduk;
        private TextBox textHargaProduk;
        private Label label3;
        private TextBox textStokProduk;
        private Label label4;
        private Label label5;
        private ComboBox comboKategori;
        private Button btnSimpan;
        private Button btnCancel;
        private Label titleFormProduk;
    }
}
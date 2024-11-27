namespace NgopiSek_Project_PBO.Views.Forms
{
    partial class FormKategori
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
            btnSimpan = new Button();
            textNamaKategori = new TextBox();
            label2 = new Label();
            titleFormProduk = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(348, 424);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(176, 56);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(186, 115, 55);
            btnSimpan.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(153, 424);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(176, 56);
            btnSimpan.TabIndex = 20;
            btnSimpan.Text = "Save";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // textNamaKategori
            // 
            textNamaKategori.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNamaKategori.Location = new Point(94, 256);
            textNamaKategori.Name = "textNamaKategori";
            textNamaKategori.Size = new Size(506, 55);
            textNamaKategori.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 211);
            label2.Name = "label2";
            label2.Size = new Size(198, 42);
            label2.TabIndex = 12;
            label2.Text = "Nama Kategori";
            // 
            // titleFormProduk
            // 
            titleFormProduk.AutoSize = true;
            titleFormProduk.Font = new Font("Poppins SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleFormProduk.Location = new Point(153, 60);
            titleFormProduk.Name = "titleFormProduk";
            titleFormProduk.Size = new Size(381, 84);
            titleFormProduk.TabIndex = 11;
            titleFormProduk.Text = "Form Kategori";
            // 
            // FormKategori
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 576);
            Controls.Add(btnCancel);
            Controls.Add(btnSimpan);
            Controls.Add(textNamaKategori);
            Controls.Add(label2);
            Controls.Add(titleFormProduk);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKategori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKategori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSimpan;
        private TextBox textNamaKategori;
        private Label label2;
        private Label titleFormProduk;
    }
}
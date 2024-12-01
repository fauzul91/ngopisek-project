namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    partial class Category_Form
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
            label1 = new Label();
            textNamaKategori = new TextBox();
            btnAdd = new Button();
            label2 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gilroy-SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 260);
            label1.Name = "label1";
            label1.Size = new Size(178, 29);
            label1.TabIndex = 0;
            label1.Text = "Nama Kategori";
            // 
            // textNamaKategori
            // 
            textNamaKategori.Font = new Font("Poppins", 14F);
            textNamaKategori.Location = new Point(154, 317);
            textNamaKategori.Name = "textNamaKategori";
            textNamaKategori.Size = new Size(474, 49);
            textNamaKategori.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 145, 83);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(154, 429);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(224, 58);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gilroy-SemiBold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 131);
            label2.Name = "label2";
            label2.Size = new Size(254, 44);
            label2.TabIndex = 0;
            label2.Text = "Form Kategori";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(53, 53, 53);
            btnCancel.Location = new Point(404, 429);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(224, 58);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Category_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 661);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textNamaKategori);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Category_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNamaKategori;
        private Button btnAdd;
        private Label label2;
        private Button btnCancel;
    }
}
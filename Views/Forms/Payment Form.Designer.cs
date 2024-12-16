namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    partial class PaymentForm
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
            textNamaMetodePembayaran = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(53, 53, 53);
            btnCancel.Location = new Point(401, 422);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(224, 58);
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
            btnAdd.Location = new Point(151, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(224, 58);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textNamaMetodePembayaran
            // 
            textNamaMetodePembayaran.Font = new Font("Poppins", 14F);
            textNamaMetodePembayaran.Location = new Point(151, 310);
            textNamaMetodePembayaran.Name = "textNamaMetodePembayaran";
            textNamaMetodePembayaran.Size = new Size(474, 49);
            textNamaMetodePembayaran.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gilroy-SemiBold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 124);
            label2.Name = "label2";
            label2.Size = new Size(463, 44);
            label2.TabIndex = 4;
            label2.Text = "Form Metode Pembayaran";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gilroy-SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 253);
            label1.Name = "label1";
            label1.Size = new Size(315, 29);
            label1.TabIndex = 5;
            label1.Text = "Nama Metode Pembayaran";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(776, 605);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textNamaMetodePembayaran);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox textNamaMetodePembayaran;
        private Label label2;
        private Label label1;
    }
}
namespace NgopiSek_Project_PBO.Views.Controls
{
    partial class UCKategori
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
            btnTambah = new Button();
            label1 = new Label();
            dataGridKategori = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridKategori).BeginInit();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.White;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambah.Location = new Point(1114, 139);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(216, 56);
            btnTambah.TabIndex = 32;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 105);
            label1.Name = "label1";
            label1.Size = new Size(373, 127);
            label1.TabIndex = 31;
            label1.Text = "Kategori";
            // 
            // dataGridKategori
            // 
            dataGridKategori.AllowUserToOrderColumns = true;
            dataGridKategori.AllowUserToResizeColumns = false;
            dataGridKategori.AllowUserToResizeRows = false;
            dataGridKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridKategori.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridKategori.BackgroundColor = Color.White;
            dataGridKategori.BorderStyle = BorderStyle.None;
            dataGridKategori.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(186, 115, 55);
            dataGridViewCellStyle1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(186, 115, 55);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridKategori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridKategori.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridKategori.EnableHeadersVisualStyles = false;
            dataGridKategori.GridColor = Color.White;
            dataGridKategori.Location = new Point(104, 260);
            dataGridKategori.Name = "dataGridKategori";
            dataGridKategori.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridKategori.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridKategori.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridKategori.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridKategori.Size = new Size(1226, 833);
            dataGridKategori.TabIndex = 30;
            dataGridKategori.CellContentClick += dataGridKategori_CellContentClick;
            // 
            // UCKategori
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTambah);
            Controls.Add(label1);
            Controls.Add(dataGridKategori);
            Name = "UCKategori";
            Size = new Size(1452, 1166);
            Load += UCKategori_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridKategori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambah;
        private Label label1;
        private DataGridView dataGridKategori;
    }
}

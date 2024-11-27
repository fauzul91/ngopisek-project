namespace NgopiSek_Project_PBO.Views.Controls
{
    partial class UCTransaksi
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTransaksi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 105);
            label1.Name = "label1";
            label1.Size = new Size(420, 127);
            label1.TabIndex = 31;
            label1.Text = "Transaksi";
            // 
            // dataGridTransaksi
            // 
            dataGridTransaksi.AllowUserToOrderColumns = true;
            dataGridTransaksi.AllowUserToResizeColumns = false;
            dataGridTransaksi.AllowUserToResizeRows = false;
            dataGridTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTransaksi.BackgroundColor = Color.White;
            dataGridTransaksi.BorderStyle = BorderStyle.None;
            dataGridTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(186, 115, 55);
            dataGridViewCellStyle5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(186, 115, 55);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridTransaksi.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridTransaksi.EnableHeadersVisualStyles = false;
            dataGridTransaksi.GridColor = Color.White;
            dataGridTransaksi.Location = new Point(104, 260);
            dataGridTransaksi.Name = "dataGridTransaksi";
            dataGridTransaksi.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridTransaksi.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridTransaksi.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridTransaksi.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridTransaksi.Size = new Size(1226, 833);
            dataGridTransaksi.TabIndex = 30;
            dataGridTransaksi.CellContentClick += dataGridTransaksi_CellContentClick;
            // 
            // UCTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridTransaksi);
            Name = "UCTransaksi";
            Size = new Size(1452, 1166);
            Load += UCTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridTransaksi;
    }
}

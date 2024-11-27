using NgopiSek_Project_PBO.App.Contexts;
using NgopiSek_Project_PBO.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Project_PBO.Views.Controls
{
    public partial class UCTransaksi : UserControl
    {
        public UCTransaksi()
        {
            InitializeComponent();
        }

        private void dataGridTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void UCTransaksi_Load(object sender, EventArgs e)
        {
            dataGridTransaksi.DataBindingComplete += DataGridTransaksi_DataBindingComplete;
            LoadDataTransaksi();
        }

        private void LoadDataTransaksi()
        {
            try
            {
                dataGridTransaksi.AllowUserToAddRows = false;
                dataGridTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridTransaksi.ReadOnly = true;

                var dataTransaksi = TransaksiContext.All();

                if (dataTransaksi == null || dataTransaksi.Rows.Count == 0)
                {
                    MessageBox.Show("No transaction data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridTransaksi.Columns.Clear();

                var nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nomor",
                    Name = "Nomor",
                    ReadOnly = true,
                    Width = 50
                };

                dataGridTransaksi.Columns.Add(nomorColumn);
                dataGridTransaksi.DataSource = dataTransaksi;

                CustomizeColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeColumnHeaders()
        {
            var hiddenColumns = new[] { "id_transaksi", "id_metode_pembayaran", "id_kasir" };

            foreach (DataGridViewColumn column in dataGridTransaksi.Columns)
            {
                if (hiddenColumns.Contains(column.Name))
                {
                    column.Visible = false;
                }
                else
                {
                    column.HeaderText = column.Name switch
                    {
                        "tanggal_transaksi" => "Tanggal Transaksi",
                        "customer_name" => "Nama Pelanggan",
                        "nama_metode_pembayaran" => "Nama Metode Pembayaran",
                        "nama_kasir" => "Nama Kasir",
                        _ => column.HeaderText
                    };
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void AddRowNumbers()
        {
            if (dataGridTransaksi.Columns.Contains("Nomor"))
            {
                foreach (DataGridViewRow row in dataGridTransaksi.Rows)
                {
                    row.Cells["Nomor"].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Kolom 'Nomor' tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridTransaksi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddRowNumbers();
        }
    }
}

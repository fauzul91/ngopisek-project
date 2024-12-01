using NgopiSek_Desktop_App_V2.App.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    public partial class UCOrder : UserControl
    {
        public UCOrder()
        {
            InitializeComponent();
        }

        private void dataGridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

        }

        private void UCOrder_Load(object sender, EventArgs e)
        {
            dataGridOrder.DataBindingComplete += DataGridOrder_DataBindingComplete;
            LoadDataTransaksi();
        }

        private void LoadDataTransaksi()
        {
            try
            {
                dataGridOrder.AllowUserToAddRows = false;
                dataGridOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridOrder.ReadOnly = true;

                var dataTransaksi = TransaksiContext.All();

                if (dataTransaksi == null || dataTransaksi.Rows.Count == 0)
                {
                    MessageBox.Show("No transaction data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridOrder.Columns.Clear();

                var nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nomor",
                    Name = "Nomor",
                    ReadOnly = true,
                    Width = 50
                };

                dataGridOrder.Columns.Add(nomorColumn);
                dataGridOrder.DataSource = dataTransaksi;

                CustomizeColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeColumnHeaders()
        {
            var hiddenColumns = new[] { "id_transaksi", "id_metode_pembayaran", "id_kasir" };

            foreach (DataGridViewColumn column in dataGridOrder.Columns)
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
            if (dataGridOrder.Columns.Contains("Nomor"))
            {
                foreach (DataGridViewRow row in dataGridOrder.Rows)
                {
                    row.Cells["Nomor"].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Kolom 'Nomor' tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddRowNumbers();
        }
    }
}

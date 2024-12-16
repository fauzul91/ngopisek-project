using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Desktop_App_V2.Views.Controls.Kasir
{
    public partial class UC_HistoryPesanan : UserControl
    {
        public UC_HistoryPesanan()
        {
            InitializeComponent();
        }

        private void UC_HistoryPesanan_Load(object sender, EventArgs e)
        {
            dataGridHistoryOrder.DataBindingComplete += DataGridHistoryOrder_DataBindingComplete;
            LoadHistoryKasir();
        }

        private void dataGridHistoryOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dataGridHistoryOrder.Columns["Aksi"].Index)
            {
                try
                {
                    var row = dataGridHistoryOrder.Rows[e.RowIndex];
                    int idTransaksi = Convert.ToInt32(row.Cells["id_transaksi"].Value);
                    DetailPesanan detailPesanan = new DetailPesanan(idTransaksi);
                    detailPesanan.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Data tidak ada! Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadHistoryKasir();
            }
            if (!DateTime.TryParse(searchText, out DateTime parsedDate))
            {
                MessageBox.Show("Please enter a valid date in the format YYYY-MM-DD.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var searchResults = TransaksiContext.SearchHistorykasir(searchText);

                if (searchResults != null && searchResults.Rows.Count > 0)
                {
                    dataGridHistoryOrder.DataSource = searchResults;
                    if (!dataGridHistoryOrder.Columns.Contains("Nomor"))
                    {
                        var nomorColumn = new DataGridViewTextBoxColumn
                        {
                            HeaderText = "Nomor",
                            Name = "Nomor",
                            ReadOnly = true,
                            Width = 50
                        };
                        dataGridHistoryOrder.Columns.Insert(0, nomorColumn);
                    }

                    AddRowNumbers();
                }
                else
                {
                    MessageBox.Show("No product found matching your search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHistoryKasir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadHistoryKasir();
            }
        }

        private void LoadHistoryKasir()
        {
            try
            {
                dataGridHistoryOrder.AllowUserToAddRows = false;
                dataGridHistoryOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridHistoryOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridHistoryOrder.ReadOnly = true;

                var dataHistoryKasir = TransaksiContext.LoadHistoryKasir();

                if (dataHistoryKasir == null || dataHistoryKasir.Rows.Count == 0)
                {
                    MessageBox.Show("No transaction data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridHistoryOrder.Columns.Clear();

                var nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nomor",
                    Name = "Nomor",
                    ReadOnly = true,
                    Width = 50
                };

                dataGridHistoryOrder.Columns.Add(nomorColumn);
                dataGridHistoryOrder.DataSource = dataHistoryKasir;

                CustomizeColumnHeaders();
                AddButtonColumn("Aksi", "Detail");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeColumnHeaders()
        {
            var hiddenColumns = new[] { "id_transaksi", "id_metode_pembayaran", "id_metode_pesanan", "id_kasir" };

            foreach (DataGridViewColumn column in dataGridHistoryOrder.Columns)
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
                        "nama_customer" => "Nama Pelanggan",
                        "nama_metode_pembayaran" => "Metode Pembayaran",
                        "nama_metode_pesanan" => "Metode Pesanan",
                        "nama_kasir" => "Nama Kasir",
                        _ => column.HeaderText
                    };
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void AddRowNumbers()
        {
            if (dataGridHistoryOrder.Columns.Contains("Nomor"))
            {
                foreach (DataGridViewRow row in dataGridHistoryOrder.Rows)
                {
                    row.Cells["Nomor"].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Kolom 'Nomor' tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButtonColumn(string columnName, string buttonText)
        {
            if (!dataGridHistoryOrder.Columns.Contains(columnName))
            {
                var buttonColumn = new DataGridViewButtonColumn
                {
                    Name = columnName,
                    HeaderText = columnName,
                    Text = buttonText,
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                };
                dataGridHistoryOrder.Columns.Add(buttonColumn);
            }
        }

        private void DataGridHistoryOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddRowNumbers();
        }
    }
}

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

namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    public partial class UCOrder : UserControl
    {
        public UCOrder()
        {
            InitializeComponent();
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

                AddButtonColumn("Aksi", "Detail");
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

        private void AddButtonColumn(string columnName, string buttonText)
        {
            if (!dataGridOrder.Columns.Contains(columnName))
            {
                var buttonColumn = new DataGridViewButtonColumn
                {
                    Name = columnName,
                    HeaderText = columnName,
                    Text = buttonText,
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                };
                dataGridOrder.Columns.Add(buttonColumn);
            }
        }
        private void DataGridOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddRowNumbers();
        }

        private void searchIcon_Click_1(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDataTransaksi();
            }
            if (!DateTime.TryParse(searchText, out DateTime parsedDate))
            {
                MessageBox.Show("Please enter a valid date in the format YYYY-MM-DD.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var searchResults = TransaksiContext.SearchTransaksi(searchText);

                if (searchResults != null && searchResults.Rows.Count > 0)
                {
                    dataGridOrder.DataSource = searchResults;
                    if (!dataGridOrder.Columns.Contains("Nomor"))
                    {
                        var nomorColumn = new DataGridViewTextBoxColumn
                        {
                            HeaderText = "Nomor",
                            Name = "Nomor",
                            ReadOnly = true,
                            Width = 50
                        };
                        dataGridOrder.Columns.Insert(0, nomorColumn);
                    }

                    AddRowNumbers();
                }
                else
                {
                    MessageBox.Show("No product found matching your search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataTransaksi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDataTransaksi();
            }
        }

        private void dataGridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dataGridOrder.Columns["Aksi"].Index)
            {
                try
                {
                    var row = dataGridOrder.Rows[e.RowIndex];
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
    }
}

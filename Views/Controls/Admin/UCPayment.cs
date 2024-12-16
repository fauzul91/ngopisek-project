using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.App.Models;
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
    public partial class UCPayment : UserControl
    {
        public UCPayment()
        {
            InitializeComponent();
            Load += UCPayment_Load;
        }

        private void LoadDataPayment()
        {
            try
            {
                dataGridPayment.AllowUserToAddRows = false;
                dataGridPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridPayment.ReadOnly = true;

                var dataPayment = PaymentContext.All();

                if (dataPayment == null || dataPayment.Rows.Count == 0)
                {
                    MessageBox.Show("No payment data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridPayment.Columns.Clear();

                var nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nomor",
                    Name = "Nomor",
                    ReadOnly = true,
                    Width = 50
                };

                dataGridPayment.Columns.Add(nomorColumn);
                dataGridPayment.DataSource = dataPayment;

                CustomizeColumnHeaders();                
                AddRowNumbers();
                AddButtonColumn("Update", "Edit");
                AddButtonColumn("Delete", "Hapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeColumnHeaders()
        {
            var hiddenColumns = "id_metode_pembayaran";

            foreach (DataGridViewColumn column in dataGridPayment.Columns)
            {
                if (hiddenColumns.Contains(column.Name))
                {
                    column.Visible = false;
                }
                else
                {
                    column.HeaderText = column.Name switch
                    {
                        "nama_metode_pembayaran" => "Metode Pembayaran",
                        _ => column.HeaderText
                    };
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void AddRowNumbers()
        {
            if (dataGridPayment.Columns.Contains("Nomor"))
            {
                foreach (DataGridViewRow row in dataGridPayment.Rows)
                {
                    row.Cells["Nomor"].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Kolom 'Nomor' tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridPayment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddRowNumbers();
        }

        private void AddButtonColumn(string columnName, string buttonText)
        {
            if (!dataGridPayment.Columns.Contains(columnName))
            {
                var buttonColumn = new DataGridViewButtonColumn
                {
                    Name = columnName,
                    HeaderText = columnName,
                    Text = buttonText,
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                };
                dataGridPayment.Columns.Add(buttonColumn);
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new();
            paymentForm.Show();
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDataPayment();
            }

            try
            {
                var searchResults = PaymentContext.SearchPayment(searchText);

                if (searchResults != null && searchResults.Rows.Count > 0)
                {
                    dataGridPayment.DataSource = searchResults;
                    if (!dataGridPayment.Columns.Contains("Nomor"))
                    {
                        var nomorColumn = new DataGridViewTextBoxColumn
                        {
                            HeaderText = "Nomor",
                            Name = "Nomor",
                            ReadOnly = true,
                            Width = 50
                        };
                        dataGridPayment.Columns.Insert(0, nomorColumn);
                    }

                    if (!dataGridPayment.Columns.Contains("Update"))
                    {
                        AddButtonColumn("Update", "Edit");
                    }

                    if (!dataGridPayment.Columns.Contains("Delete"))
                    {
                        AddButtonColumn("Delete", "Hapus");
                    }

                    AddRowNumbers();
                }
                else
                {
                    MessageBox.Show("No payment found matching your search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataPayment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDataPayment();
            }
        }

        private void dataGridPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridPayment.Columns["Update"].Index)
            {
                try
                {
                    var idPayment = Convert.ToInt32(dataGridPayment.Rows[e.RowIndex].Cells["id_metode_pembayaran"].Value);
                    var paymentData = PaymentContext.GetPaymentById(idPayment);

                    if (paymentData.Rows.Count > 0)
                    {
                        var payment = new M_MetodePembayaran
                        {
                            id_metode_pembayaran = idPayment,
                            nama_metode_pembayaran = paymentData.Rows[0]["nama_metode_pembayaran"].ToString(),
                        };

                        using var updateForm = new PaymentForm();
                        updateForm.PopulateForm(payment);
                        updateForm.ShowDialog();

                        if (updateForm.DialogResult == DialogResult.OK)
                        {
                            LoadDataPayment();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data payment tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error handling update action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == dataGridPayment.Columns["Delete"].Index)
            {
                try
                {
                    var result = MessageBox.Show("Apakah anda yakin ingin menghapus metode pembayaran ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var idPayment = Convert.ToInt32(dataGridPayment.Rows[e.RowIndex].Cells["id_metode_pembayaran"].Value);
                        PaymentContext.DeletePayment(idPayment);
                        MessageBox.Show("Metode pembayaran berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataPayment();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error handling delete action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UCPayment_Load(object sender, EventArgs e)
        {
            dataGridPayment.DataBindingComplete += DataGridPayment_DataBindingComplete;
            dataGridPayment.CellContentClick += dataGridPayment_CellContentClick;
            LoadDataPayment();
        }              
    }
}

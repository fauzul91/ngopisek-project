using NgopiSek_Project_PBO.App.Contexts;
using NgopiSek_Project_PBO.App.Models;
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
    public partial class UCKategori : UserControl
    {
        public UCKategori()
        {
            InitializeComponent();
            Load += UCKategori_Load;            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormKategori tambahKategori = new FormKategori();
            tambahKategori.Show();
        }

        private void dataGridKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridKategori.Columns["Update"].Index)
            {
                try
                {
                    var idCategory = Convert.ToInt32(dataGridKategori.Rows[e.RowIndex].Cells["id_kategori"].Value);
                    var categoryData = CategoryContext.GetCategoryById(idCategory);

                    if (categoryData.Rows.Count > 0)
                    {
                        var kategori = new M_Kategori
                        {
                            id_kategori = idCategory,
                            nama_kategori = categoryData.Rows[0]["nama_kategori"].ToString()
                        };

                        using (var updateForm = new FormKategori())
                        {
                            updateForm.PopulateForm(kategori);
                            updateForm.ShowDialog();

                            if (updateForm.DialogResult == DialogResult.OK)
                            {
                                LoadDataCategory();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data kategori tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error handling update action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UCKategori_Load(object sender, EventArgs e)
        {
            dataGridKategori.DataBindingComplete += DataGridCategory_DataBindingComplete;
            LoadDataCategory();
        }

        private void LoadDataCategory()
        {
            try
            {
                dataGridKategori.AllowUserToAddRows = false;
                dataGridKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridKategori.ReadOnly = true;

                var dataCategory = CategoryContext.All();

                if (dataCategory == null || dataCategory.Rows.Count == 0)
                {
                    MessageBox.Show("No category data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridKategori.Columns.Clear();

                var nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nomor",
                    Name = "Nomor",
                    ReadOnly = true,
                    Width = 50
                };

                dataGridKategori.Columns.Add(nomorColumn);
                dataGridKategori.DataSource = dataCategory;

                CustomizeColumnHeaders();
                AddButtonColumn("Update", "Edit");
                AddRowNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading category data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeColumnHeaders()
        {
            var hiddenColumns = new[] { "id_kategori" };

            foreach (DataGridViewColumn column in dataGridKategori.Columns)
            {
                if (hiddenColumns.Contains(column.Name))
                {
                    column.Visible = false;
                }
                else
                {
                    column.HeaderText = column.Name switch
                    {
                        "nama_kategori" => "Nama Kategori",
                        _ => column.HeaderText
                    };
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void AddRowNumbers()
        {
            if (dataGridKategori.Columns.Contains("Nomor"))
            {
                foreach (DataGridViewRow row in dataGridKategori.Rows)
                {
                    row.Cells["Nomor"].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Kolom 'Nomor' tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridCategory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddRowNumbers();
        }

        private void AddButtonColumn(string columnName, string buttonText)
        {
            if (!dataGridKategori.Columns.Contains(columnName))
            {
                var buttonColumn = new DataGridViewButtonColumn
                {
                    Name = columnName,
                    HeaderText = columnName,
                    Text = buttonText,
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dataGridKategori.Columns.Add(buttonColumn);
            }
        }
    }
}
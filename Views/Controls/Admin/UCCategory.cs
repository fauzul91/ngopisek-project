using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.App.Models;
using NgopiSek_Desktop_App_V2.Views.Forms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    public partial class UCCategory : UserControl
    {
        public UCCategory()
        {
            InitializeComponent();
            Load += UCCategory_Load;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category_Form formCategory = new Category_Form();
            formCategory.Show();
        }

        private void LoadDataCategory()
        {
            try
            {
                dataGridCategory.AllowUserToAddRows = false;
                dataGridCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridCategory.ReadOnly = true;

                if (!dataGridCategory.Columns.Contains("Nomor"))
                {
                    var nomorColumn = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Nomor",
                        Name = "Nomor",
                        ReadOnly = true,
                        Width = 50
                    };
                    dataGridCategory.Columns.Add(nomorColumn);
                }

                var dataCategory = CategoryContext.All();

                if (dataCategory == null || dataCategory.Rows.Count == 0)
                {
                    MessageBox.Show("No category data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridCategory.DataSource = dataCategory;
                CustomizeColumnHeaders();
                AddButtonColumn("Update", "Edit");
                AddButtonColumn("Delete", "Hapus");
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

            foreach (DataGridViewColumn column in dataGridCategory.Columns)
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
            if (dataGridCategory.Columns.Contains("Nomor"))
            {
                foreach (DataGridViewRow row in dataGridCategory.Rows)
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
            if (!dataGridCategory.Columns.Contains(columnName))
            {
                var buttonColumn = new DataGridViewButtonColumn
                {
                    Name = columnName,
                    HeaderText = columnName,
                    Text = buttonText,
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dataGridCategory.Columns.Add(buttonColumn);
            }
        }

        private void UCCategory_Load(object sender, EventArgs e)
        {
            dataGridCategory.DataBindingComplete += DataGridCategory_DataBindingComplete;
            LoadDataCategory();
        }

        private void dataGridCategory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridCategory.Columns["Update"].Index)
            {
                try
                {
                    var idCategory = Convert.ToInt32(dataGridCategory.Rows[e.RowIndex].Cells["id_kategori"].Value);
                    var categoryData = CategoryContext.GetCategoryById(idCategory);

                    if (categoryData.Rows.Count > 0)
                    {
                        var kategori = new M_Kategori
                        {
                            id_kategori = idCategory,
                            nama_kategori = categoryData.Rows[0]["nama_kategori"].ToString()
                        };

                        using var updateForm = new Category_Form();
                        updateForm.PopulateForm(kategori);
                        updateForm.ShowDialog();

                        if (updateForm.DialogResult == DialogResult.OK)
                        {
                            LoadDataCategory();
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

            if (e.ColumnIndex == dataGridCategory.Columns["Delete"].Index)
            {
                try
                {
                    var result = MessageBox.Show("Apakah anda yakin ingin menghapus kategori ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var idKategori = Convert.ToInt32(dataGridCategory.Rows[e.RowIndex].Cells["id_kategori"].Value);
                        bool isDeleted = CategoryContext.DeleteCategory(idKategori);

                        if (isDeleted)
                        {
                            MessageBox.Show("Kategori berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataCategory();
                        }
                        else
                        {
                            MessageBox.Show("Tidak dapat menghapus kategori. Masih ada produk yang terkait!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error handling delete action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textSearch.Focus();
                return;
            }

            try
            {
                var searchResults = CategoryContext.SearchCategory(searchText);

                if (searchResults != null && searchResults.Rows.Count > 0)
                {
                    dataGridCategory.DataSource = searchResults;
                    if (!dataGridCategory.Columns.Contains("Nomor"))
                    {
                        var nomorColumn = new DataGridViewTextBoxColumn
                        {
                            HeaderText = "Nomor",
                            Name = "Nomor",
                            ReadOnly = true,
                            Width = 50
                        };
                        dataGridCategory.Columns.Insert(0, nomorColumn);
                    }

                    if (!dataGridCategory.Columns.Contains("Update"))
                    {
                        AddButtonColumn("Update", "Edit");
                    }

                    AddRowNumbers();
                }
                else
                {
                    MessageBox.Show("No categories found matching your search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataCategory(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDataCategory(); 
            }
        }
    }
}

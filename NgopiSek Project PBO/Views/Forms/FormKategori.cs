using NgopiSek_Project_PBO.App.Contexts;
using NgopiSek_Project_PBO.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Project_PBO.Views.Forms
{
    public partial class FormKategori : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int KategoriId { get; set; }

        public FormKategori()
        {
            InitializeComponent();
            UpdateButtonText();
            ClearFields();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Input tidak valid. Harap isi semua data dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            M_Kategori kategori = new M_Kategori
            {
                nama_kategori = textNamaKategori.Text
            };

            try
            {
                if (IsEditMode)
                {
                    kategori.id_kategori = KategoriId;
                    CategoryContext.UpdateCategory(kategori);
                    MessageBox.Show("Kategori berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CategoryContext.AddCategory(kategori);
                    MessageBox.Show("Kategori berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan kategori: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textNamaKategori.Text))
            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textNamaKategori.Clear();
        }

        public void PopulateForm(M_Kategori kategori)
        {
            textNamaKategori.Text = kategori.nama_kategori;
            IsEditMode = true;
            KategoriId = kategori.id_kategori;

            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            btnSimpan.Text = IsEditMode ? "Update" : "Tambah";
        }
    }
}

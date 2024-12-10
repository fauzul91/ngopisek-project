using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    public partial class Product_Form : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int ProductId { get; set; }

        public Product_Form()
        {
            InitializeComponent();
            UpdateButtonText();
            LoadCategoryData();
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            if (!ValidateInput())
            {
                MessageBox.Show("Input tidak valid. Harap isi semua data dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            M_Produk produk = new M_Produk
            {
                nama_produk = textNamaProduk.Text,
                harga_produk = int.Parse(textHargaProduk.Text),
                stok_produk = int.Parse(textStokProduk.Text),
                id_kategori = (int)comboKategori.SelectedValue,
                foto_produk = ConvertImageToByteArray(pictureProduct.Image) // Konversi gambar ke byte array
            };

            try
            {
                if (IsEditMode)
                {
                    produk.id_produk = ProductId;
                    ProductContext.UpdateProduct(produk);
                    MessageBox.Show("Produk berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ProductContext.AddProduct(produk);
                    MessageBox.Show("Produk berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textNamaProduk.Text) ||
                !int.TryParse(textHargaProduk.Text, out _) ||
                !int.TryParse(textStokProduk.Text, out int stokProduk) ||
                stokProduk < 0 ||
                comboKategori.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textNamaProduk.Clear();
            textHargaProduk.Clear();
            textStokProduk.Clear();
            comboKategori.SelectedIndex = -1;
        }

        private void LoadCategoryData()
        {
            var dataKategori = CategoryContext.All();
            comboKategori.DisplayMember = "nama_kategori";
            comboKategori.ValueMember = "id_kategori";
            comboKategori.DataSource = dataKategori;
            comboKategori.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void PopulateForm(M_Produk produk)
        {
            LoadCategoryData();

            textNamaProduk.Text = produk.nama_produk;
            textHargaProduk.Text = produk.harga_produk.ToString();
            textStokProduk.Text = produk.stok_produk.ToString();
            
            comboKategori.SelectedValue = produk.id_kategori;

            if (produk.foto_produk != null && produk.foto_produk.Length > 0)
            {
                pictureProduct.Image = ConvertByteArrayToImage(produk.foto_produk);
            }
            
            else
            {
                pictureProduct.Image = null; 
            }

            IsEditMode = true;
            ProductId = produk.id_produk;

            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            btnAdd.Text = IsEditMode ? "Update" : "Tambah";
        }

        private void pressBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureProduct.Image = Image.FromFile(openFileDialog.FileName);
                    pictureProduct.SizeMode = PictureBoxSizeMode.Zoom; // Atur ulang untuk memastikan
                }
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Simpan dalam format PNG
                return ms.ToArray();
            }
        }

        private Image ConvertByteArrayToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;

            using (var ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }
    }
}

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

namespace NgopiSek_Desktop_App_V2.Views.Controls.Kasir
{
    public partial class UC_HomeKasir : UserControl
    {
        public event Action<string, decimal> OnAddToCart;
        public UC_HomeKasir()
        {
            InitializeComponent();
            LoadCategoryButtons();
            LoadProductItems();            
        }

        private void LoadCategoryButtons()
        {
            catPanel.Controls.Clear();
            DataTable categories = CategoryContext.All();

            foreach (DataRow row in categories.Rows)
            {
                Button btnKategori = new Button
                {
                    Text = row["nama_kategori"].ToString(),
                    Tag = Convert.ToInt32(row["id_kategori"]),
                    Width = 200,
                    Height = 80,
                    BackColor = ColorTranslator.FromHtml("#FF9153"),
                    ForeColor = Color.White,
                    Margin = new Padding(50, 30, 50, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance =
                    {
                        BorderSize = 0
                    },
                    Font = new Font("Gilroy", 10, FontStyle.Bold)
                };
                btnKategori.Click += btnKategori_Click;
                catPanel.Controls.Add(btnKategori);
            }
        }

        private void LoadProductItems(int categoryId = 0, string searchText = null)
        {
            productPanel.Controls.Clear();
            DataTable products;

            if (!string.IsNullOrEmpty(searchText))
            {
                products = ProductContext.SearchProduct(searchText);

                if (products == null || products.Rows.Count == 0)
                {
                    MessageBox.Show("Produk yang Anda cari tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductItems();
                    return;
                }
            }

            else
            {
                products = ProductContext.All();
            }

            if (categoryId != 0) 
            {
                var filterKategori = products.AsEnumerable().Where(row => row.Field<int>("id_kategori") == categoryId);

                if (!filterKategori.Any()) 
                {
                    MessageBox.Show("Data produk tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductItems(); 
                    return;
                }

                products = filterKategori.CopyToDataTable(); 
            }
           
            foreach (DataRow row in products.Rows)
            {
                Panel productPanelItem = new Panel
                {
                    Width = 220,
                    Height = 350,
                    Padding = new Padding(10),
                    Margin = new Padding(35),
                    BackColor = Color.White,
                };

                byte[] fotoProduk = row["foto_produk"] as byte[];
                Image productImage;

                if (fotoProduk == null)
                {
                    productImage = Properties.Resources.Starbucks_Strawberry;
                }
                else
                {
                    productImage = Image.FromStream(new MemoryStream(fotoProduk));
                }

                PictureBox pictureBox = new PictureBox
                {
                    Image = productImage,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 180,
                    Height = 180,
                    Margin = new Padding(10)
                };
                pictureBox.Location = new Point(20, 20);

                Label lblNamaProduk = new Label
                {
                    Text = row["nama_produk"].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 180,
                    Height = 30,
                    Font = new Font("Gilroy", 10, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#353535"),
                };
                lblNamaProduk.Location = new Point(20, 210);

                Label lblHarga = new Label
                {
                    Text = $"Rp {row["harga_produk"].ToString()}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 180,
                    Height = 30,
                    Font = new Font("Gilroy", 10, FontStyle.Regular),
                    ForeColor = ColorTranslator.FromHtml("#353535"),
                };
                lblHarga.Location = new Point(20, 245);

                Button btnAddToCart = new Button
                {
                    Text = "Add to cart",
                    Width = 180,
                    Height = 40,
                    BackColor = ColorTranslator.FromHtml("#FF9153"),
                    ForeColor = Color.White,
                    Font = new Font("Gilroy", 10, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Margin = new Padding(0, 10, 0, 10)
                };
                btnAddToCart.Location = new Point(20, 290);

                productPanelItem.Controls.Add(pictureBox);
                productPanelItem.Controls.Add(lblNamaProduk);
                productPanelItem.Controls.Add(lblHarga);
                productPanelItem.Controls.Add(btnAddToCart);
                productPanel.Controls.Add(productPanelItem);
            }
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int categoryId = int.Parse(clickedButton.Tag.ToString());
            LoadProductItems(categoryId);
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.Trim();
            
            if (string.IsNullOrEmpty(searchText))
            {
                LoadProductItems();
                return;
            }
            else
            {
                LoadProductItems(0, searchText); 
            }
        }

        public void btnAddToCart_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Panel productPanelItem = clickedButton.Parent as Panel;

            string namaProduk = productPanelItem.Controls.OfType<Label>().First(l => l.Text.StartsWith("Rp") == false).Text;
            string hargaProdukStr = productPanelItem.Controls.OfType<Label>().First(l => l.Text.StartsWith("Rp")).Text;
            decimal hargaProduk = decimal.Parse(hargaProdukStr.Replace("Rp", "").Trim());

            OnAddToCart?.Invoke(namaProduk, hargaProduk);
        }
    }
}

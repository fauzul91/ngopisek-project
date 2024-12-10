using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.App.Core;
using NgopiSek_Desktop_App_V2.App.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            LoadPaymentButtons();
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
                    FlatAppearance = { BorderSize = 0 },
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
                products = ProductContext.DisplayProducts();
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
                    Padding = new Padding(25),
                    Margin = new Padding(25),
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
                    Margin = new Padding(0, 10, 0, 10),
                    Tag = row["id_produk"]
                };
                btnAddToCart.Location = new Point(20, 290);

                btnAddToCart.Click += btnAddToCart_Click;
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

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null || clickedButton.Tag == null)
            {
                MessageBox.Show("Terjadi kesalahan: Produk tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id_produk = int.Parse(clickedButton.Tag.ToString());
            DataTable dataProducts = ProductContext.GetProdukById(id_produk);

            if (dataProducts != null && dataProducts.Rows.Count > 0)
            {
                var produk = new M_Produk()
                {
                    id_produk = (int)dataProducts.Rows[0]["id_produk"],
                    nama_produk = dataProducts.Rows[0]["nama_produk"].ToString(),
                    harga_produk = (int)dataProducts.Rows[0]["harga_produk"],
                    stok_produk = 0,
                    id_kategori = (int)dataProducts.Rows[0]["id_kategori"],
                    foto_produk = dataProducts.Rows[0]["foto_produk"] as byte[],
                };

                CartContext.AddToCart(produk);
                UpdateCartUI();
            }
        }

        private void UpdateCartUI()
        {
            var cartItems = CartContext.GetCartItems();
            flowOrderDetails.Controls.Clear();

            foreach (var item in cartItems)
            {
                Panel panelItem = new Panel
                {
                    Width = flowOrderDetails.Width - 50,
                    Height = 120,
                    BackColor = Color.White,
                    Padding = new Padding(5),
                    Margin = new Padding(5)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Image = item.foto_produk != null ? Image.FromStream(new MemoryStream(item.foto_produk)) : Properties.Resources.Starbucks_Strawberry,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 80,
                    Height = 80,
                    Location = new Point(10, 10)
                };

                Label lblNamaProduk = new Label
                {
                    Text = item.nama_produk,
                    Font = new Font("Gilroy", 10, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#353535"),
                    Width = 200,
                    Location = new Point(100, 10)
                };

                Label lblHarga = new Label
                {
                    Text = $"Rp {item.harga_produk}",
                    Font = new Font("Gilroy", 10, FontStyle.Regular),
                    ForeColor = ColorTranslator.FromHtml("#353535"),
                    Width = 300,
                    Location = new Point(100, 40)
                };

                DataTable productData = ProductContext.GetProdukById(item.id_produk);
                int maxStock = productData != null && productData.Rows.Count > 0
                    ? Convert.ToInt32(productData.Rows[0]["stok_produk"])
                    : 0;

                Button btnMin = new Button
                {
                    Text = "-",
                    Width = 40,
                    Height = 40,
                    Location = new Point(100, 70),
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = item.id_produk
                };
                btnMin.Click += (s, e) =>
                {
                    int currentQty = CartContext.GetCartQuantity(item.id_produk);
                    int newQuantity = Math.Max(currentQty - 1, 1);
                    CartContext.UpdateQuantityCart(item.id_produk, newQuantity, maxStock);
                    UpdateCartUI();
                };

                TextBox txtQuantity = new TextBox
                {
                    Text = item.stok_produk.ToString(),
                    TextAlign = HorizontalAlignment.Center,
                    Width = 50,
                    Location = new Point(150, 75)
                };
                txtQuantity.TextChanged += (s, e) =>
                {
                    if (int.TryParse(txtQuantity.Text, out int newQty))
                    {
                        if (CartContext.UpdateQuantityCart(item.id_produk, newQty, maxStock))
                        {
                            UpdateCartUI();
                        }
                        else
                        {
                            txtQuantity.Text = item.stok_produk.ToString();
                        }
                    }
                };

                Button btnMax = new Button
                {
                    Text = "+",
                    Width = 40,
                    Height = 40,
                    Location = new Point(210, 70),
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = item.id_produk
                };
                btnMax.Click += (s, e) =>
                {
                    int currentQty = CartContext.GetCartQuantity(item.id_produk);
                    int newQuantity = Math.Min(currentQty + 1, maxStock);

                    if (currentQty >= maxStock)
                    {
                        MessageBox.Show("Stok maksimum telah tercapai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    CartContext.UpdateQuantityCart(item.id_produk, newQuantity, maxStock);
                    UpdateCartUI();
                };

                Button btnRemove = new Button
                {
                    Text = "X",
                    Width = 40,
                    Height = 40,
                    Location = new Point(260, 70),
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = item.id_produk
                };
                btnRemove.Click += (s, e) =>
                {
                    CartContext.RemoveFromCart(item.id_produk);
                    UpdateCartUI();
                };

                panelItem.Controls.Add(pictureBox);
                panelItem.Controls.Add(lblNamaProduk);
                panelItem.Controls.Add(lblHarga);
                panelItem.Controls.Add(btnMin);
                panelItem.Controls.Add(txtQuantity);
                panelItem.Controls.Add(btnMax);
                panelItem.Controls.Add(btnRemove);
                flowOrderDetails.Controls.Add(panelItem);
            }

            decimal total = cartItems.Sum(x => x.harga_produk * x.stok_produk);
            OrderSummary();
        }

        private void LoadPaymentButtons()
        {
            flowPaymentMethod.Controls.Clear();
            DataTable paymentMethod = TransaksiContext.GetPaymentMethod();

            foreach (DataRow row in paymentMethod.Rows)
            {
                Button btnPaymentMethod = new Button
                {
                    Text = row["nama_metode_pembayaran"].ToString(),
                    Tag = Convert.ToInt32(row["id_metode_pembayaran"]),
                    Width = 150,
                    Height = 50,
                    BackColor = Color.White,
                    ForeColor = ColorTranslator.FromHtml("#353535"),
                    Margin = new Padding(20, 25, 20, 25),
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Font = new Font("Gilroy", 10, FontStyle.Bold)
                };
                btnPaymentMethod.Click += btnPaymentMethod_Click;
                flowPaymentMethod.Controls.Add(btnPaymentMethod);
            }
        }

        private int selectedPaymentMethodId = 0;
        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            selectedPaymentMethodId = int.Parse(clickedButton.Tag.ToString());

            foreach (Button btn in flowPaymentMethod.Controls)
            {
                btn.BackColor = Color.White;
            }
            clickedButton.BackColor = Color.Orange;
        }

        private void OrderSummary()
        {
            var cartItems = CartContext.GetCartItems();

            decimal subTotal = cartItems.Sum(item => item.harga_produk * item.stok_produk);
            decimal tax = subTotal * 0.10m;
            decimal total = subTotal + tax;

            textSubTotal.Text = $"Rp {subTotal:N0}";
            textTax.Text = $"Rp {tax:N0}";
            textTotal.Text = $"Rp {total:N0}";
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var cartItems = CartContext.GetCartItems();
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Keranjang Anda masih kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selectedPaymentMethodId == 0)
            {
                MessageBox.Show("Pilih metode pembayaran", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaCustomer = textCustomerName.Text;
            if (string.IsNullOrWhiteSpace(namaCustomer))
            {
                MessageBox.Show("Masukkan nama customer", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalHarga = cartItems.Sum(item => item.harga_produk * item.stok_produk);
            int idKasir = Session.CurrentUserId;
            DateTime tanggalTransaksi = DateTime.Now;

            List<M_DetailTransaksi> detailTransaksiList = cartItems.Select(item => new M_DetailTransaksi
            {
                id_produk = item.id_produk,
                kuantitas = item.stok_produk,
            }).ToList();

            var transaksiContext = new TransaksiContext();
            transaksiContext.InsertTransaksi(
                idKasir,
                namaCustomer,
                tanggalTransaksi,
                totalHarga,
                selectedPaymentMethodId,
                detailTransaksiList);
            foreach (var item in cartItems)
            {
                ProductContext.UpdateStokProduk(item.id_produk, item.stok_produk);
            }
            CartContext.ClearCart();
            UpdateCartUI();
        }
    }
}

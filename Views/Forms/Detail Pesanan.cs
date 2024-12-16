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

namespace NgopiSek_Desktop_App_V2.Views.Forms
{
    public partial class DetailPesanan : Form
    {
        private int _idTransaksi;

        public DetailPesanan(int idTransaksi)
        {
            InitializeComponent();
            _idTransaksi = idTransaksi;

            LoadDetailProduk(_idTransaksi);
            LoadDetailPesanan();
            LoadOrderSummary();
        }

        private void LoadDetailProduk(int idTransaksi)
        {
            flowDetailsOrder.Controls.Clear();
            var listProduk = DetailTransaksi.LoadDetailPesanan(_idTransaksi);
            foreach (DataRow produk in listProduk.Rows)
            {
                byte[] fotoProduk = produk["foto_produk"] as byte[];

                AddProductToFlowLayoutPanel(
                    fotoProduk,
                    produk["nama_produk"].ToString(),
                    produk["nama_kategori"].ToString(),
                    Convert.ToInt32(produk["kuantitas"]),
                    Convert.ToDecimal(produk["total_harga"]));
            };
        }
        private void LoadDetailPesanan()
        {
            try
            {
                DataTable dataDetailPesanan = DetailTransaksi.LoadDetailPesanan(_idTransaksi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading detail pesanan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadOrderSummary()
        {
            try
            {
                decimal subTotal = DetailTransaksi.LoadSubTotal(_idTransaksi);
                decimal tax = DetailTransaksi.LoadTax(_idTransaksi);
                decimal totalAmount = DetailTransaksi.LoadTotal(_idTransaksi);

                textSubTotal.Text = $"Rp{subTotal:N0}";
                textTax.Text = $"Rp{tax:N0}";
                textTotalAmount.Text = $"Rp{totalAmount:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading summary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductToFlowLayoutPanel(byte[] fotoProduk, string namaProduk, string kategoriProduk, int kuantitas, decimal total)
        {
            Panel productPanel = new Panel
            {
                Width = flowDetailsOrder.Width - 10, 
                Height = 120,
                BorderStyle = BorderStyle.None,
                Padding = new Padding(5)
            };

            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                Location = new Point(0, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (fotoProduk != null && fotoProduk.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(fotoProduk))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    pictureBox.Image = Properties.Resources.Starbucks_Strawberry; 
                }
            }
            else
            {
                pictureBox.Image = Properties.Resources.Starbucks_Strawberry;
            }

            Label lblNamaProduk = new Label
            {
                Text = namaProduk,
                Location = new Point(100, 35),
                AutoSize = true,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#353535")
            };

            Label lblKategoriProduk = new Label
            {
                Text = kategoriProduk,
                Location = new Point(100, 68),
                AutoSize = true
            };

            Label lblKuantitas = new Label
            {
                Text = kuantitas.ToString(),
                Location = new Point(productPanel.Width / 2, (productPanel.Height / 2) - 10),
                Font = new Font("Poppins", 10, FontStyle.Regular),
                ForeColor = ColorTranslator.FromHtml("#353535"),
                AutoSize = true
            };

            Label lblTotal = new Label
            {
                Text = $"Rp{total:n0}",
                Location = new Point(productPanel.Width - 120, (productPanel.Height / 2) - 5),
                AutoSize = true,
                ForeColor = ColorTranslator.FromHtml("#353535"),
                Font = new Font("Poppins", 10, FontStyle.Regular)
            };

            productPanel.Controls.Add(pictureBox);
            productPanel.Controls.Add(lblNamaProduk);
            productPanel.Controls.Add(lblKategoriProduk);
            productPanel.Controls.Add(lblKuantitas);
            productPanel.Controls.Add(lblTotal);

            flowDetailsOrder.Controls.Add(productPanel);
        }
    }
}

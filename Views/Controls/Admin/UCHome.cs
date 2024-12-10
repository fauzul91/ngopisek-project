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

namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
            LoadHomeData();
            LoadTop5Products();
        }

        private void LoadHomeData()
        {
            DataTable salesData = HomeContext.GetSummarySales();
            if (salesData.Rows.Count > 0)
            {
                dataRevenue.Text = $"{salesData.Rows[0]["total_semua_transaksi"]}";
            }

            DataTable customerData = HomeContext.CountCustomers();
            if (customerData.Rows.Count > 0)
            {
                dataCustomers.Text = $"{customerData.Rows[0]["total_customer"]}";
            }

            DataTable productData = HomeContext.CountProducts();
            if (productData.Rows.Count > 0)
            {
                dataProducts.Text = $"{productData.Rows[0]["total_products"]}";
            }
        }

        private void LoadTop5Products()
        {
            DataTable top5Products = HomeContext.All();

            flowTop5Products.Width = 345; 
            flowTop5Products.Height = 456;
            flowTop5Products.FlowDirection = FlowDirection.TopDown;
            flowTop5Products.WrapContents = false;  
            flowTop5Products.AutoScroll = true;  

            for (int i = 0; i < top5Products.Rows.Count; i++)
            {
                Panel productPanel = new Panel();
                productPanel.Width = 250;   
                productPanel.Height = 90;   
                productPanel.Margin = new Padding(
                    (flowTop5Products.Width - productPanel.Width) / 2, 
                    3, 
                    0, 
                    3  
                );

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 80;    
                pictureBox.Height = 80; 
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 

                if (top5Products.Rows[i]["foto_produk"] != DBNull.Value)
                {
                    byte[] imgData = (byte[])top5Products.Rows[i]["foto_produk"];
                    pictureBox.Image = ByteArrayToImage(imgData);
                }
                else
                {
                    pictureBox.Image = Properties.Resources.Americano;
                }

                Label label = new Label();
                label.Text = top5Products.Rows[i]["nama_produk"].ToString();
                label.TextAlign = ContentAlignment.MiddleLeft; 
                label.AutoSize = false; 
                label.Width = 150; 
                label.Height = 80; 
                label.Font = new Font("Gilroy-☞", 10, FontStyle.Regular);
                label.Location = new Point(90, 5); 

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(label);

                flowTop5Products.Controls.Add(productPanel);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void dataGridRecentInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void LoadRecentInvoice()
        {
            try
            {
                dataGridRecentInvoice.AllowUserToAddRows = false;
                dataGridRecentInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridRecentInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridRecentInvoice.ReadOnly = true;

                var dataRecentInvoice = HomeContext.GetRecentInvoice();

                if (dataRecentInvoice == null || dataRecentInvoice.Rows.Count == 0)
                {
                    MessageBox.Show("No transsaction data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridRecentInvoice.Columns.Clear();

                var nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nomor",
                    Name = "Nomor",
                    ReadOnly = true,
                    Width = 50
                };

                dataGridRecentInvoice.Columns.Add(nomorColumn);
                dataGridRecentInvoice.DataSource = dataRecentInvoice;

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

            foreach (DataGridViewColumn column in dataGridRecentInvoice.Columns)
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
                        "nama_kasir" => "Nama Kasir",
                        _ => column.HeaderText
                    };
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void AddRowNumbers()
        {
            if (dataGridRecentInvoice.Columns.Contains("Nomor"))
            {
                foreach (DataGridViewRow row in dataGridRecentInvoice.Rows)
                {
                    row.Cells["Nomor"].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Kolom 'Nomor' tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridRecentInvoice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddRowNumbers();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            dataGridRecentInvoice.DataBindingComplete += DataGridRecentInvoice_DataBindingComplete;
            LoadRecentInvoice();
        }
    }
}

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
    public partial class PaymentForm : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int PaymentId { get; set; }
        public PaymentForm()
        {
            InitializeComponent();
            UpdateButtonText();
            ClearFields();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textNamaMetodePembayaran.Text))
            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textNamaMetodePembayaran.Clear();
        }

        public void PopulateForm(M_MetodePembayaran payment)
        {
            textNamaMetodePembayaran.Text = payment.nama_metode_pembayaran;
            IsEditMode = true;
            PaymentId = payment.id_metode_pembayaran;

            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            btnAdd.Text = IsEditMode ? "Update" : "Tambah";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Input tidak valid. Harap isi semua data dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            M_MetodePembayaran payment = new M_MetodePembayaran
            {
                nama_metode_pembayaran = textNamaMetodePembayaran.Text
            };

            try
            {
                if (IsEditMode)
                {
                    payment.id_metode_pembayaran = PaymentId;
                    PaymentContext.UpdatePayment(payment);
                    MessageBox.Show("Metode pembayaran berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    PaymentContext.AddPayment(payment);
                    MessageBox.Show("Metode pembayaran berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
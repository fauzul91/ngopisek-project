using NgopiSek_Desktop_App_V2.App.Core;
using NgopiSek_Desktop_App_V2.App.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Desktop_App_V2.App.Contexts
{
    internal class TransaksiContext : DatabaseWrapper
    {
        public static DataTable All()
        {
            string query = @"
            SELECT 
	            tr.id_transaksi, 
	            tr.tanggal_transaksi, 
	            tr.nama_customer, 
	            m.nama_metode_pembayaran, 
	            p.nama_pengguna as nama_kasir 
            FROM transaksi tr
            JOIN metode_pembayaran m on m.id_metode_pembayaran = tr.id_metode_pembayaran
            JOIN pengguna p on p.id_pengguna = tr.id_kasir";

            DataTable dataTransaksi = queryExecutor(query);
            return dataTransaksi;
        }

        public static DataTable GetProdukById(int id)
        {
            string query = @"
            SELECT 
	            tr.id_transaksi, 
	            tr.tanggal_transaksi, 
	            tr.customer_name, 
	            m.nama_metode_pembayaran, 
	            p.nama_pengguna as nama_kasir 
            FROM transaksi tr
            JOIN metode_pembayaran m on m.id_metode_pembayaran = tr.id_metode_pembayaran
            JOIN pengguna p on p.id_pengguna = tr.id_kasir
            WHERE tr.id_transaksi = @id
            ORDER BY p.id_produk";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataTransaksi = queryExecutor(query, parameters);
            return dataTransaksi;
        }

        public static DataTable SearchTransaksi(string textTransaksi)
        {
            string query = @"
            SELECT 
	            tr.id_transaksi, 
	            tr.tanggal_transaksi, 
	            tr.nama_customer, 
	            m.nama_metode_pembayaran, 
	            p.nama_pengguna as nama_kasir 
            FROM transaksi tr
            JOIN metode_pembayaran m on m.id_metode_pembayaran = tr.id_metode_pembayaran
            JOIN pengguna p on p.id_pengguna = tr.id_kasir
            WHERE to_char(tr.tanggal_transaksi, 'DD/MM/YYYY') ILIKE @textTransaksi
            ORDER BY tr.id_transaksi
            ";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@textTransaksi", NpgsqlTypes.NpgsqlDbType.Text ) { Value = $"%{textTransaksi}%" }
            };

            DataTable searchTransaksi = queryExecutor(query, parameters);
            return searchTransaksi;
        }

        public static DataTable GetPaymentMethod()
        {
            string query = @"
            SELECT id_metode_pembayaran, nama_metode_pembayaran
            FROM metode_pembayaran
            ";

            DataTable dataPayment = queryExecutor(query);
            return dataPayment;
        }

        public void InsertTransaksi(
            int idKasir,
            string namaCustomer,
            DateTime tanggalTransaksi,  
            decimal totalHarga,
            int idMetodePembayaran,
            List<M_DetailTransaksi> detailTransaksiList)
            {
            try
            {
                string queryTransaksi = @"
                INSERT INTO transaksi 
                (id_kasir, nama_customer, tanggal_transaksi, id_metode_pembayaran) 
                VALUES (@idKasir, @namaCustomer, @tanggalTransaksi, @idMetodePembayaran) 
                RETURNING id_transaksi";

                NpgsqlParameter[] transaksiParams = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@idKasir", idKasir),
                    new NpgsqlParameter("@namaCustomer", namaCustomer),
                    new NpgsqlParameter("@tanggalTransaksi", DateTime.Now),  // Mengambil tanggal dan waktu saat ini
                    new NpgsqlParameter("@idMetodePembayaran", idMetodePembayaran)
                };

                DataTable resultTable = DatabaseWrapper.queryExecutor(queryTransaksi, transaksiParams);
                int idTransaksi = Convert.ToInt32(resultTable.Rows[0]["id_transaksi"]);
                string queryDetailTransaksi = @"
                INSERT INTO detail_transaksi 
                (id_transaksi, id_produk, kuantitas) 
                VALUES (@idTransaksi, @idProduk, @kuantitas)";

                foreach (var detail in detailTransaksiList)
                {
                    NpgsqlParameter[] detailParams = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@idTransaksi", idTransaksi),
                        new NpgsqlParameter("@idProduk", detail.id_produk),
                        new NpgsqlParameter("@kuantitas", detail.kuantitas),
                    };

                    DatabaseWrapper.commandExecutor(queryDetailTransaksi, detailParams);
                }

                MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan transaksi: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    }
}

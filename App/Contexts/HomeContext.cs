using NgopiSek_Desktop_App_V2.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Desktop_App_V2.App.Contexts
{
    internal class HomeContext : DatabaseWrapper
    {
        public static DataTable All()
        {
            string query = @"
            SELECT p.id_produk, 
                   p.nama_produk, 
                   p.foto_produk,
                   SUM(dt.kuantitas) AS total_terjual
            FROM detail_transaksi dt
            JOIN produk p ON p.id_produk = dt.id_produk
            JOIN transaksi tr ON tr.id_transaksi = dt.id_transaksi
            GROUP BY p.id_produk, p.nama_produk, p.foto_produk
            ORDER BY total_terjual DESC
            LIMIT 5";

            DataTable dataTop5Products = queryExecutor(query);
            return dataTop5Products;
        }

        public static DataTable GetSummarySales()
        {
            string query = @"SELECT SUM(dt.kuantitas * pr.harga_produk) AS total_semua_transaksi
            FROM transaksi tr
            JOIN detail_transaksi dt ON dt.id_transaksi = tr.id_transaksi
            JOIN produk pr ON pr.id_produk = dt.id_produk";

            DataTable dataSummarySales = queryExecutor(query);
            return dataSummarySales;
        }

        public static DataTable CountCustomers()
        {
            string query = @"
            SELECT COUNT(tr.nama_customer) AS total_customer
            FROM transaksi tr";

            DataTable dataCustomers = queryExecutor(query);
            return dataCustomers;
        }
        public static DataTable CountProducts()
        {
            string query = @"SELECT COUNT(*) AS total_products FROM produk";

            DataTable dataCustomers = queryExecutor(query);
            return dataCustomers;
        }

        public static DataTable GetRecentInvoice()
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
            ORDER BY tr.tanggal_transaksi DESC
            LIMIT 10";

            DataTable dataTransaksi = queryExecutor(query);
            return dataTransaksi;
        }
    }
}

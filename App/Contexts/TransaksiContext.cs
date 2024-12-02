using NgopiSek_Desktop_App_V2.App.Core;
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
	            tr.customer_name, 
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
    }
}

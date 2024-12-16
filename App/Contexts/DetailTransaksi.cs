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
    internal class DetailTransaksi : DatabaseWrapper
    {        
        public static DataTable LoadDetailPesanan(int idTransaksi)
        {
            string query = @"
            SELECT 
                p.foto_produk, 
                p.nama_produk,
	            k.nama_kategori,
                dt.kuantitas, 
                (p.harga_produk * dt.kuantitas) AS total_harga
            FROM detail_transaksi dt
            JOIN produk p ON p.id_produk = dt.id_produk
            JOIN kategori k ON k.id_kategori = p.id_kategori
            WHERE dt.id_transaksi = @id_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_transaksi", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idTransaksi }
            };

            DataTable dataDetailPesanan = queryExecutor(query, parameters);
            return dataDetailPesanan;
        }

        public static decimal LoadSubTotal(int idTransaksi)
        {
            string query = @"
            SELECT 
                SUM(p.harga_produk * dt.kuantitas) AS sub_total                 
            FROM detail_transaksi dt
            JOIN produk p ON p.id_produk = dt.id_produk
            WHERE dt.id_transaksi = @id_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_transaksi", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idTransaksi }
            };

            DataTable result = queryExecutor(query, parameters);
            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["sub_total"]);
            }
            return 0;
        }

        public static decimal LoadTax(int idTransaksi)
        {
            return LoadSubTotal(idTransaksi) * 0.1M;           
        }

        public static decimal LoadTotal(int idTransaksi)
        {
            return LoadSubTotal(idTransaksi) * 1.1M;
        }
    }
}

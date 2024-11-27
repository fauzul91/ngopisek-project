using NgopiSek_Project_PBO.App.Core;
using NgopiSek_Project_PBO.App.Models;
using Npgsql;
using System;
using System.Data;

namespace NgopiSek_Project_PBO.App.Contexts
{
    internal class ProductContext : DatabaseWrapper
    {
        private static string table = "produk";

        public static DataTable All()
        {
            string query = @"
            SELECT
                p.id_produk,
                p.nama_produk,
                p.harga_produk,
                p.stok_produk,
                p.id_kategori,
                k.nama_kategori
            FROM produk p
            JOIN kategori k on p.id_kategori = k.id_kategori
            ORDER BY p.id_produk";

            DataTable dataProduk = queryExecutor(query);
            return dataProduk;
        }

        public static DataTable GetProdukById(int id)
        {
            string query = @"
            SELECT
                p.id_produk,
                p.nama_produk,
                p.harga_produk,
                p.stok_produk,
                p.id_kategori,
                k.nama_kategori
            FROM produk p
            JOIN kategori k on p.id_kategori = k.id_kategori
            WHERE p.id_produk = @id
            ORDER BY p.id_produk";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataProduk = queryExecutor(query, parameters);
            return dataProduk;
        }

        public static void AddProduct(M_Produk produkBaru)
        {
            string query = $"INSERT INTO produk(nama_produk, harga_produk, stok_produk, id_kategori) VALUES(@nama_produk, @harga_produk, @stok_produk, @id_kategori)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_produk", produkBaru.nama_produk),
                new NpgsqlParameter("@harga_produk", produkBaru.harga_produk),
                new NpgsqlParameter("@stok_produk", produkBaru.stok_produk),
                new NpgsqlParameter("@id_kategori", produkBaru.id_kategori),
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateProduct(M_Produk produk)
        {
            string query = $@"
            UPDATE {table} 
            SET 
                nama_produk = @nama_produk, 
                harga_produk = @harga_produk, 
                stok_produk = @stok_produk, 
                id_kategori = @id_kategori
            WHERE id_produk = @id_produk";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_produk", produk.nama_produk),
                new NpgsqlParameter("@harga_produk", produk.harga_produk),
                new NpgsqlParameter("@stok_produk", produk.stok_produk),
                new NpgsqlParameter("@id_kategori", produk.id_kategori),
                new NpgsqlParameter("@id_produk", produk.id_produk),
            };

            commandExecutor(query, parameters);
        }
    }
}

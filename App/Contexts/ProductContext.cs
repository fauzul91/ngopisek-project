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
                k.nama_kategori,
                p.foto_produk
            FROM produk p
            JOIN kategori k on p.id_kategori = k.id_kategori
            ORDER BY p.id_produk";

            DataTable dataProduk = queryExecutor(query);
            return dataProduk;
        }
        public static DataTable DisplayProducts()
        {
            string query = @"
            SELECT
                p.id_produk,
                p.nama_produk,
                p.harga_produk,
                p.stok_produk,
                p.id_kategori,
                k.nama_kategori,
                p.foto_produk
            FROM produk p
            JOIN kategori k on p.id_kategori = k.id_kategori
            WHERE p.stok_produk > 20
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
                k.nama_kategori,
                p.foto_produk
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
            if (produkBaru.stok_produk < 0)
            {
                throw new ArgumentException("Stok produk tidak boleh negatif");
            }

            string query = $@"
            INSERT INTO produk(nama_produk, harga_produk, stok_produk, id_kategori, foto_produk) 
            VALUES(@nama_produk, @harga_produk, @stok_produk, @id_kategori, @foto_produk)";

            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nama_produk", produkBaru.nama_produk),
            new NpgsqlParameter("@harga_produk", produkBaru.harga_produk),
            new NpgsqlParameter("@stok_produk", produkBaru.stok_produk),
            new NpgsqlParameter("@id_kategori", produkBaru.id_kategori),
            new NpgsqlParameter("@foto_produk", NpgsqlTypes.NpgsqlDbType.Bytea)
            {
                Value = produkBaru.foto_produk ?? (object)DBNull.Value
            }
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateProduct(M_Produk produk)
        {
            if (produk.stok_produk < 0)
            {
                throw new ArgumentException("Stok produk tidak boleh negatif.");
            }

            string query = $@"
            UPDATE {table} 
            SET 
                nama_produk = @nama_produk, 
                harga_produk = @harga_produk, 
                stok_produk = @stok_produk, 
                id_kategori = @id_kategori,
                foto_produk = @foto_produk
            WHERE id_produk = @id_produk";

            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nama_produk", produk.nama_produk),
            new NpgsqlParameter("@harga_produk", produk.harga_produk),
            new NpgsqlParameter("@stok_produk", produk.stok_produk),
            new NpgsqlParameter("@id_kategori", produk.id_kategori),
            new NpgsqlParameter("@foto_produk", NpgsqlTypes.NpgsqlDbType.Bytea)
            {
            Value = produk.foto_produk ?? (object)DBNull.Value
            },
                new NpgsqlParameter("@id_produk", produk.id_produk),
            };
            commandExecutor(query, parameters);
        }

        public static DataTable SearchProduct(string textProduct)
        {
            string query = @"
            SELECT p.id_produk, p.nama_produk, p.harga_produk, p.stok_produk, p.id_kategori, k.nama_kategori, p.foto_produk 
            FROM produk p 
            JOIN kategori k ON p.id_kategori = k.id_kategori 
            WHERE p.nama_produk ILIKE @textProduct 
            ORDER BY p.nama_produk";

            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@textProduct", NpgsqlTypes.NpgsqlDbType.Text) { Value = "%" + textProduct + "%" }
            };

            DataTable dataCategory = queryExecutor(query, parameters);
            return dataCategory;
        }

        public static DataTable GetStockProduct()
        {
            string query = @"
            SELECT stok_produk 
            FROM produk
            WHERE id_produk = @id";            

            DataTable dataStok = queryExecutor(query);
            return dataStok;
        }

        public static void UpdateStokProduk(int id_produk, int kuantitas)
        {
            string query = @"
            UPDATE produk 
            SET stok_produk = stok_produk - @kuantitas
            WHERE id_produk = @id_produk";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_produk", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id_produk },
                new NpgsqlParameter("@kuantitas", NpgsqlTypes.NpgsqlDbType.Integer) { Value = kuantitas }
            };

            queryExecutor(query, parameters);
        }
    }
}

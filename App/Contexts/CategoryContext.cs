using Microsoft.VisualBasic.Devices;
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
    internal class CategoryContext : DatabaseWrapper
    {
        private static string table = "kategori";
        public static DataTable All()
        {
            string query = "SELECT id_kategori, nama_kategori FROM kategori ORDER BY id_kategori";

            DataTable dataKategori = queryExecutor(query);
            return dataKategori;
        }

        public static DataTable GetCategoryById(int id)
        {
            string query = "SELECT id_kategori, nama_kategori FROM kategori WHERE id_kategori = @id ORDER BY id_kategori";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataKategori = queryExecutor(query, parameters);
            return dataKategori;
        }

        public static void AddCategory(M_Kategori kategoriBaru)
        {
            string query = $"INSERT INTO kategori(nama_kategori) VALUES(@nama_kategori)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_kategori", kategoriBaru.nama_kategori)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateCategory(M_Kategori kategori)
        {
            string query = $@"
            UPDATE {table} 
            SET 
                nama_kategori = @nama_kategori                 
            WHERE id_kategori = @id_kategori";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_kategori", kategori.nama_kategori),
                new NpgsqlParameter("@id_kategori", kategori.id_kategori)
            };

            commandExecutor(query, parameters);
        }

        public static DataTable SearchCategory(string textCategory)
        {
            string query = "SELECT id_kategori, nama_kategori FROM kategori WHERE nama_kategori ILIKE @textCategory ORDER BY nama_kategori";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@textCategory", NpgsqlTypes.NpgsqlDbType.Text) { Value = "%" + textCategory + "%" }
            };

            DataTable dataCategory = queryExecutor(query, parameters);
            return dataCategory;
        }
    }
}
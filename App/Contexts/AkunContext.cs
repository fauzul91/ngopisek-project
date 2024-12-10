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
    internal class AkunContext : DatabaseWrapper
    {
        private static string table = "role";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            try
            {
                return queryExecutor(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in All(): {ex.Message}");
                return null;
            }
        }

        public static bool cekUsername(string username, string table)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE username_{table} = @username";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", username),
            };

            try
            {
                openConnection();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddRange(parameters);
                int result = Convert.ToInt32(command.ExecuteScalar());
                closeConnection();
                return result > 0;
            }
            catch (Exception ex)
            {
                closeConnection();
                Console.WriteLine($"Error in cekUsername(): {ex.Message}");
                return false;
            }
        }

        public static bool Registrasi(M_Pengguna pengguna)
        {
            string query = $"INSERT INTO pengguna (nama_pengguna, username_pengguna, password_pengguna, id_role) " +
                           $"VALUES(@nama, @username, @password, @id_role)";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@nama", pengguna.nama_pengguna),
                new NpgsqlParameter("@username", pengguna.username_pengguna),
                new NpgsqlParameter("@password", pengguna.password_pengguna),
                new NpgsqlParameter("@id_role", pengguna.id_role)
            };

            try
            {
                openConnection();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddRange(parameters);
                int result = command.ExecuteNonQuery();
                closeConnection();
                return result > 0;
            }
            catch (Exception ex)
            {
                closeConnection();
                Console.WriteLine($"Error in Registrasi(): {ex.Message}");
                return false;
            }
        }
        public static bool Login(string username, string password, out int idRole, out int idPengguna)
        {
            string query = "SELECT id_role, id_pengguna FROM pengguna WHERE username_pengguna = @username AND password_pengguna = @password";

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@username", username),
        new NpgsqlParameter("@password", password),
            };

            idRole = 0;
            idPengguna = 0;

            try
            {
                openConnection();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddRange(parameters);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idRole = Convert.ToInt32(reader["id_role"]);
                        idPengguna = Convert.ToInt32(reader["id_pengguna"]);
                        return true; // Login sukses
                    }
                }
                closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                closeConnection();
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

    }
}

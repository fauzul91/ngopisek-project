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
                        return true; 
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

        public static bool Update(M_Pengguna pengguna)
        {
            try
            {
                string query = "UPDATE pengguna SET nama_pengguna = @nama_pengguna, username_pengguna = @username_pengguna, password_pengguna = @password_pengguna, foto_pengguna = @foto_pengguna WHERE id_pengguna = @id_pengguna";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@nama_pengguna", pengguna.nama_pengguna),
                    new NpgsqlParameter("@username_pengguna", pengguna.username_pengguna),
                    new NpgsqlParameter("@password_pengguna", pengguna.password_pengguna ?? (object)DBNull.Value),
                    new NpgsqlParameter("@foto_pengguna", pengguna.foto_pengguna ?? (object)DBNull.Value),
                    new NpgsqlParameter("@id_pengguna", pengguna.id_pengguna)
                };

                commandExecutor(query, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static M_Pengguna GetUserById(int userId)
        {
            M_Pengguna pengguna = null;

            try
            {
                string query = @"SELECT id_pengguna, nama_pengguna, username_pengguna, password_pengguna, foto_pengguna, id_role 
                                FROM pengguna WHERE id_pengguna = @id_pengguna";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@id_pengguna", userId)
                };

                DataTable dataTable = DatabaseWrapper.queryExecutor(query, parameters);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];

                    pengguna = new M_Pengguna
                    {
                        id_pengguna = Convert.ToInt32(row["id_pengguna"]),
                        nama_pengguna = row["nama_pengguna"].ToString(),
                        username_pengguna = row["username_pengguna"].ToString(),
                        password_pengguna = row["password_pengguna"].ToString(),
                        foto_pengguna = row["foto_pengguna"] == DBNull.Value ? null : (byte[])row["foto_pengguna"],
                        id_role = Convert.ToInt32(row["id_role"])
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return pengguna;
        }

        public static DataTable GetUsername(int idPengguna)
        {
            string query = @"
            SELECT nama_pengguna            
            FROM pengguna
            WHERE id_pengguna = @idPengguna";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idPengguna", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idPengguna }
            };

            DataTable dataGetUsername = queryExecutor(query, parameters);
            return dataGetUsername;
        }

        public static DataTable GetRole(int idPengguna)
        {
            string query = @"
            SELECT r.nama_role            
            FROM pengguna p
            JOIN role r on r.id_role = p.id_role
            WHERE id_pengguna = @idPengguna";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idPengguna", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idPengguna }
            };

            DataTable dataGetRole = queryExecutor(query, parameters);
            return dataGetRole;
        }
    }
}

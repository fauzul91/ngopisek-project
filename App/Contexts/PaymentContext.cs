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
    internal class PaymentContext : DatabaseWrapper
    {
        private static string table = "metode_pembayaran";

        public static DataTable All()
        {
            string query = @"
            SELECT id_metode_pembayaran, nama_metode_pembayaran
            FROM metode_pembayaran
            WHERE status = FALSE";

            DataTable dataPayment = queryExecutor(query);
            return dataPayment;
        }

        public static DataTable GetPaymentById(int id)
        {
            string query = @"
            SELECT id_metode_pembayaran, nama_metode_pembayaran
            FROM metode_pembayaran
            WHERE id_metode_pembayaran = @id AND status = FALSE
            ORDER BY id_metode_pembayaran";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataPayment = queryExecutor(query, parameters);
            return dataPayment;
        }

        public static void AddPayment(M_MetodePembayaran paymentBaru)
        {
            string query = $"INSERT INTO metode_pembayaran(nama_metode_pembayaran) VALUES(@nama_metode_pembayaran)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_metode_pembayaran", paymentBaru.nama_metode_pembayaran)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdatePayment(M_MetodePembayaran payment)
        {
            string query = $@"
            UPDATE {table} 
            SET 
                nama_metode_pembayaran = @nama_metode_pembayaran                 
            WHERE id_metode_pembayaran = @id_metode_pembayaran";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_metode_pembayaran", payment.nama_metode_pembayaran),
                new NpgsqlParameter("@id_metode_pembayaran", payment.id_metode_pembayaran)
            };

            commandExecutor(query, parameters);
        }

        public static DataTable SearchPayment(string textPayment)
        {
            string query = @"
            SELECT id_metode_pembayaran, nama_metode_pembayaran 
            FROM metode_pembayaran
            WHERE nama_metode_pembayaran ILIKE @textPayment AND status = FALSE ORDER BY nama_metode_pembayaran";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@textPayment", NpgsqlTypes.NpgsqlDbType.Text) { Value = "%" + textPayment + "%" }
            };

            DataTable dataPayment = queryExecutor(query, parameters);
            return dataPayment;
        }

        public static DataTable DeletePayment(int id)
        {
            string query = @"
            UPDATE metode_pembayaran
            SET status = TRUE
            WHERE id_metode_pembayaran = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataPayment = queryExecutor(query, parameters);
            return dataPayment;
        }
    }
}

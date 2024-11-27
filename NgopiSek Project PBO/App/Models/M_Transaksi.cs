using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Project_PBO.App.Models
{
    internal class M_Transaksi
    {
        [Key]
        public string id_transaksi { get; set; }
        [Required]
        public DateOnly tanggal_transaksi { get; set; }
        [Required]
        public string customer_name { get; set; }
        [ForeignKey("MetodePembayaran")]
        public int id_metode_pembayaran { get; set; }
        [ForeignKey("Kasir")]
        public int id_kasir { get; set; }

        public M_MetodePembayaran MetodePembayaran { get; set;}
        public M_Pengguna Kasir { get; set; }
    }
}

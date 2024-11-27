using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Project_PBO.App.Models
{
    internal class M_DetailTransaksi
    {
        [Key]
        public int id_detail_transaksi { get; set; }
        [ForeignKey("Transaksi")]
        public int id_transaksi { get; set; }
        [ForeignKey("Produk")]
        public int id_produk { get; set; }
        [Required]
        public int kuantitas { get; set; }
    }
}

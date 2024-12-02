using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Desktop_App_V2.App.Models
{
    public class M_Produk
    {
        [Key]
        public int id_produk { get; set; }
        [Required]
        public string nama_produk { get; set; }
        [Required]
        public int harga_produk { get; set; }
        [Required]
        public int stok_produk { get; set; }

        [ForeignKey("Kategori")]
        public int id_kategori { get; set; }  
        public byte[] foto_produk { get; set; }

        public M_Kategori Kategori { get; set; }
    }
}
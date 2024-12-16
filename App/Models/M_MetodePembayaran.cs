using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Desktop_App_V2.App.Models
{
    public class M_MetodePembayaran
    {
        [Key]
        public int id_metode_pembayaran { get; set; }
        [Required]
        public string nama_metode_pembayaran { get; set; }
        public bool status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Desktop_App_V2.App.Models
{
    public class M_Kategori
    {
        [Key]
        public int id_kategori { get; set; }
        [Required]
        public string nama_kategori { get; set; }
    }
}

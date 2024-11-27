using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Project_PBO.App.Models
{
    public class M_Kategori
    {
        [Key]
        public int id_kategori { get; set; }
        [Required]
        public string nama_kategori { get; set; }
    }
}

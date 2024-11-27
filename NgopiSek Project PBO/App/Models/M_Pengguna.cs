using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Project_PBO.App.Models
{
    internal class M_Pengguna
    {
        [Key]
        public int id_pengguna{ get; set; }
        [Required]
        public string nama_pengguna{ get; set; }
        [Required]
        public string username_pengguna{ get; set; }
        [Required]
        public string password_pengguna{ get; set; }
        [ForeignKey("Role")]
        public int id_role {  get; set; }

        public M_Role Role { get; set; }
    }
}

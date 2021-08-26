using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstERP.Entity
{
    [Table("Users")]
    class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }

    }
}


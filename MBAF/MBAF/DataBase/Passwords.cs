using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBAF.DataBase
{
    [Table("Password")]
    public class Passwords
    {
        [Key]
        public int Id { get; set; }
        [Column("Password")]
        public int Password { get; set; }
    }
}

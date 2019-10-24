using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBAF.DataBase
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }

        public string Phone { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<AudienceType> AudienceTypes { get; set; }
    }
}

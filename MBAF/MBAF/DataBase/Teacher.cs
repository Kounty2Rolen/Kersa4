using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBAF.DataBase
{
    [Table("Teacher")]
    public class Teacher
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string phone { get; set; }
        public DateTime Birthday { get; set; }

        public virtual AudienceType Audience { get; set; }
    }
}

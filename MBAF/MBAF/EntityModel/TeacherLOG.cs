using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBAF.EntityModel
{
    [Table("TeacherLOG")]
    public class TeacherLOGEF
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }

        public string Phone { get; set; }
        public DateTime Birthday { get; set; }

        public string operation { get; set; }

        public DateTime operation_dt { get; set; }
        public string operation_user { get; set; }


    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBAF.EntityModel
{
    [Table("CorpsLOG")]
    public class classcorpsLOG
    {
        public int Id { get; set; }
        public string CorpNumber { get; set; }
        public int NumberOfAudiences { get; set; }
        public string operation { get; set; }

        public DateTime operation_dt { get; set; }
        public string operation_user { get; set; }


    }

}


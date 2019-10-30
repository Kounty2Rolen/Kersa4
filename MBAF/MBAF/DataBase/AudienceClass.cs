using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBAF.DataBase
{
    [Table("AudienceTypeLOG")]
    public class AudienceClass
    {
        public int Id { get; set; }
        public string TypeOf { get; set; }
        public int Capacity { get; set; }

        [Column("Teacherid")]
        public int Teacherid { get; set; }

        [Column("CorpID")]
        public int Corpid { get; set; }
        public string Cabinet { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Corps Corp { get; set; }
        public string operation { get; set; }

        public DateTime operation_dt { get; set; }
        public string operation_user { get; set; }
    }
}

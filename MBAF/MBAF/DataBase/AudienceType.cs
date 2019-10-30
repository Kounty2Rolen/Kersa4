using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBAF.DataBase
{
    [Table("AudienceType")]
    public class AudienceType
    {
        [Key]
        public int Id { get; set; }
        public string TypeOf { get; set; }
        public int Capacity { get; set; }

        [Column("Teacherid")]
        public int Teacherid { get; set; }

        [Column("CorpID")]
        public int Corpid { get; set; }
        public string Cabinet { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Corps Corp { get; set;}
    }

}

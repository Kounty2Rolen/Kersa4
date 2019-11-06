using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBAF.EntityModel
{
    [Table("AudienceType")]
    public class AudienceType
    {
        [Key]
        public int Id { get; set; }
        public string TypeOf { get; set; }
        public int Capacity { get; set; }

        [Column("Teacherid")]
        public Nullable<int> Teacherid { get; set; }

        [Column("CorpID")]
        public Nullable<int> Corpid { get; set; }
        public string Cabinet { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Corps Corp { get; set; }

        static AudienceType()
        {


        }

    }

}

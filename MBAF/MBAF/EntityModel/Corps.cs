using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;

namespace MBAF.EntityModel
{
    [Table("Corps")]
    public class Corps
    {
        [Key]
        public int Id { get; set; }
        public string CorpNumber { get; set; }
        public int NumberOfAudiences { get; set; }

        public virtual ICollection<AudienceType> AudienceTypes { get; set; }

        public override string ToString() => CorpNumber;
    }
}

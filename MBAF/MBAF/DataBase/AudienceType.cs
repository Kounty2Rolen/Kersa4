using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBAF.DataBase
{
    [Table("AudienceType")]
    public class AudienceType
    {
        public int id { get; set; }
        public string TypeOf { get; set; }

        public int Capacity { get; set; }

        public int ResponsibleID { get; set; }

        public int CorpID { get; set; }
        public string Cabinet { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Corps> Corps { get; set; }



    }
}

namespace MBAF.DataBase
{
    public class Corps
    {

        public int id { get; set; }
        public string CorpNumber { get; set; }
        public int? NumberOfAudiences { get; set; }

        public virtual AudienceType AudienceTypes { get; set; }
    }
}

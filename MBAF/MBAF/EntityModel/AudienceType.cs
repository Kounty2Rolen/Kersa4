//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBAF.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class AudienceType
    {
        public int id { get; set; }
        public int TypeID { get; set; }
        public int Capacity { get; set; }
        public int TeacherId { get; set; }
        public int CorpID { get; set; }
        public string Cabinet { get; set; }
    
        public virtual Corps Corps { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual AudType AudType { get; set; }
    }
}

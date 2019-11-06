
using System.Data.Entity;

namespace MBAF.EntityModel
{
    public class MyDBContext : DbContext
    {
        
        internal MyDBContext() : base($@"Data Source=WIN-O6S40144ELL\SQLEXPRESS;Initial Catalog=MBAF;Integrated Security=True")
        {
        }
        public DbSet<Corps> Corps { get; set; }
        public DbSet<AudienceType> AudienceType { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<classcorpsLOG> CorpsLog { get; set; }
        public DbSet<AudienceClass> AudienceLog { get; set; }
        public DbSet<TeacherLOGEF> TeachersLog { get; set; }
        public DbSet<Passwords> passwords { get; set; }



    }
}

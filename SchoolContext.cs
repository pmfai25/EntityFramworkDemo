using System.Data.Entity;
using EntityFrameworkDemo.DAL;

namespace EntityFrameworkDemo
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=SchoolDatabase")
        {
            /*           
             * Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());
             * Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());
             * 
             * Handled by code based migration. Primary use for auto migrations when model changes
             * uses SchoolDbInitializer inherited and override from DropCreateDatabaseIfModelChanges
             * Impotant!: normally should be invoked before instantiation of school context
             * 
             */

            Database.SetInitializer<SchoolContext>(new SchoolDbInitializer());
             

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }
}
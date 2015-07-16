namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkDemo.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EntityFrameworkDemo.SchoolContext";
        }

        protected override void Seed(EntityFrameworkDemo.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var students = new Student { Name = "Pranay", Phone = "2783933", Address = "NYC", DateOfBirth = new DateTime(1991, 12, 09), Course = "Introduction to Software Engineering", Description = "None" };
            var test = new Student { Name = "test", Phone = "278000", Address = "test city", DateOfBirth = new DateTime(1990, 7, 8), Course = "Inroduction to Testing", Description = "None" };

            context.Students.Add(students);
            context.Students.Add(test);
            context.SaveChanges();
        
        }
    }
}

using System;
using System.Data.Entity;
using System.Data.SqlTypes;

namespace EntityFrameworkDemo.DAL
{
    public class SchoolDbInitializer: DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed (SchoolContext context)
        {
           base.Seed(context);
           var students =new Student{Name = "Pranay", Phone="2783933", Address = "NYC", DateOfBirth = new DateTime(1991,12,09)};

           var test = new Student { Name = "test", Phone = "278000" , Address = "test city", DateOfBirth = new DateTime(1990,7,8)};
           context.Students.Add(students);
           context.Students.Add(test);
           context.SaveChanges();
        
        }
    }
}
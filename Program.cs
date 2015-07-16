using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkDemo.DAL;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world. This is Entity framework.");

           // Database.SetInitializer(new DropCreateDatabaseAlways<SchoolContext>());
            using (var ctx = new SchoolContext())
            {
             //   new SchoolDbInitializer().InitializeDatabase(ctx);

             //  ctx.Database.Initialize(false);
                Console.WriteLine("Adding student to database using school context.");

              /*  Student stud = new Student() {StudentName = "James", DateOfBirth = new DateTime(1991-09-12), Phone = "0420617679"};              
                var stud = new Student { Name = "stud", Phone = "290909", Address = "stud city", DateOfBirth = new DateTime(1990, 1, 1).Date };          
                ctx.Students.Add(stud);
                ctx.SaveChanges();
               */
                
                
                var query = from s in ctx.Students
                    orderby s.Name
                    select s;

                Console.WriteLine("Students in Student context");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

            }
        }
    }
}

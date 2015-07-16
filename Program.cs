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

          
            using (var ctx = new SchoolContext())
            {

             //  ctx.Database.Initialize(false);
               
                Student s = new Student();
                
                Console.Write("Enter Student Details");
                Console.Write("Name: ");
                s.Name = Console.ReadLine().ToString();

                Console.Write("Phone: ");
                s.Phone = Console.ReadLine().ToString();

                Console.Write("Address: ");
                s.Address = Console.ReadLine().ToString();

                Console.Write("Course: ");
                s.Course = Console.ReadLine().ToString();
                
                Console.Write("Description: ");
                s.Description = Console.ReadLine().ToString();

                s.DateOfBirth= new DateTime(1990,12,01);
                ctx.Students.Add(s);
                ctx.SaveChanges();

                var query = from st in ctx.Students
                    orderby st.Name
                    select st;

                Console.WriteLine("Students in Student context");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.ReadLine();
            }
        }
    }
}

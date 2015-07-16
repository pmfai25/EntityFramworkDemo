using System.Collections.Generic;
using System.Diagnostics;

namespace EntityFrameworkDemo
{
    public class Standard
    {
        public Standard()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }

       
        public ICollection<Student> Students  { get; set; }
    }
}
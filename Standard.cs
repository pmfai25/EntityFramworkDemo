using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace EntityFrameworkDemo
{
    public class Standard
    {
        public Standard()
        {

        }

        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

       
        public ICollection<Student> Students  { get; set; }
    }
}
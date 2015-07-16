using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace EntityFrameworkDemo
{
    public class Student
    {
        public Student ()
        {
        }

        public  int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(60)]
        public string Course { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public Standard Standard { get; set; }

    }
}
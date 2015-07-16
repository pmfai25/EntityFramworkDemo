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
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public Standard Standard { get; set; }

    }
}
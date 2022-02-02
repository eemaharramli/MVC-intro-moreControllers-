using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Student ID {this.Id} Student name: {this.Name} Student surname: {this.Surname} Student age {this.Age}";
        }
    }
}

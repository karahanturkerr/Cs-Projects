using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ClassType { get; set; }

        public int Point { get; set; }
        public int Age { get; set; }


        public Student(string name, string surname, string classtype, int point, int age) {
            this.Name = name;
            this.SurName = surname;
            this.ClassType = classtype;
            this.Point = point;
            this.Age = age;
            
        }

    }
}

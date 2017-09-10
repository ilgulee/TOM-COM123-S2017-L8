using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOM_COM123_S2017_L8
{
    class Student : Person
    {
        public string StudentId { get; set; }

        public Student(string name, int age, string studentId)
            : base(name, age)
        {
            this.StudentId = studentId;
        }

        public void Studies()
        {
            Console.WriteLine(this.Name+" is studying!");
        }
    }
}

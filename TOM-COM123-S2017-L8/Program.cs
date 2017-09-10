using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOM_COM123_S2017_L8
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Ilgu", 44);
            person.Talks();

            var student = new Student("Lee", 42, "300851801");
            student.Talks();
            student.Studies();
        }
    }
}

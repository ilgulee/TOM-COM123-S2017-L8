using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOM_COM123_S2017_L8
{
    /// <summary>
    /// This is the Person class
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //constructors which takes two arguments

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //public methods
        /// <summary>
        /// This method enables the Person object to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name+" is talking");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOM_COM123_S2017_L8
{
    public class DomesticStudent : Student
    {
        public string DomesticAddress { get; private set; }

        public DomesticStudent(string name, int age, string studentId)
            : base(name, age, studentId)
        {

        }

        //public method
        public void SetDomesticAddress(string address)
        {
            this.DomesticAddress = address;
        }
    }
}

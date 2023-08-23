using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Offline : Course
    {
        public override void Subcribe(Student std)
        {

            Console.WriteLine("Offline Course Subcribed");
           // throw new NotImplementedException();
        }
    }
}

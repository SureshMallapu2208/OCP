using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class OnlineClass : Course
    {
        public override void Subcribe(Student std)
        {
            Console.WriteLine("Online Course Subcribed");
        }
    }
}

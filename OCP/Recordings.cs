﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Recordings : Course
    {
        public override void Subcribe(Student std)
        {
            Console.WriteLine("Recordings Course Subcribed");
        }
    }
}

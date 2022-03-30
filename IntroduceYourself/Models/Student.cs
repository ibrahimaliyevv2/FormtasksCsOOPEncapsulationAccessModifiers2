using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student:Human
    {
        public string GroupNo { get; set; }

        public override void Introduce()
        {
            Console.WriteLine("I am a student");
        }
    }
}

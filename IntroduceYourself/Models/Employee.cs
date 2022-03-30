using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee:Human
    {
        public string Position { get; set; }

        public override void Introduce() 
        {
            Console.WriteLine("I am an employee");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract void Introduce();
    }
}

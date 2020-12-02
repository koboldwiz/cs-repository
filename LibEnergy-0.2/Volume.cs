using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    public abstract class Volume
    {

        public double volume { get; set; }

        public Volume() { }

        public abstract double calculate(MicroState ms);
       
    }
}

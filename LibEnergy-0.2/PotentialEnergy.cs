using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class PotentialEnergy : EnergyBase
    {
        public PotentialEnergy()
        { }

        public double Leonard_Jones(double r, double q)
        {
            e = 1 / Math.Pow(r, 6) + 1 / Math.Pow(q, 12);
            return e;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    public abstract class MicroState : State
    {
        protected int nstates; // factorial
        protected AngularMomentum angularMomentum;

        public MicroState(int n, double a)
        {
            this.nstates = n;
            this.angularMomentum.lowerBoundAngularMomentum = a;
        }

        public double calculate_microstate()
        { }

        //public abstract double calculate_microstate();

        public double calculate_volume(Volume v)
        {

            return delabeledVolume(nstates, v.volume, angularMomentum.lowerBoundAngularMomentum);

        }

        

        protected double delabeledVolume(int n, double volume, double angularMomentumLowerBound)
        {
            return (1 / factorial(n) * 1 / Math.Pow(angularMomentumLowerBound, 3 * n) * volume);
        }

        protected int factorial(int n)
        {
            if (n == 0 || n == 1)
            {

                return 1;
            }
            return n * factorial(n--);

        }

    }
}

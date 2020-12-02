using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class DefiniteIntegral : Integral
    {
        protected Functor fa, fb;
        public DefiniteIntegral(Functor fa, Functor fb)
        {
            this.fa = fa;
            this.fb = fb;
        }
        public double calculate()
        {

            return fb.dof() - fa.dof();

        }
    }
}

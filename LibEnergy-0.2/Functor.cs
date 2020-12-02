using System;
using System.Collections.Generic;
using System.Text;

using Energy_cs.problemsolver;

namespace Energy_cs
{
    class Functor
    {
        public Function f;

        public Functor(Function f0)
        {
            this.f = f;
        }

        public double dof()
        {
            return (f.f());
        }
    }
}

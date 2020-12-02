using System;
using System.Collections.Generic;
using System.Text;


namespace Energy_cs
{
    namespace problemsolver
    {
        

        class Function4 : Function
        {
            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }
            public double t { get; set; }

            public Function4(double x, double y, double z, double t)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.t = t;
            }

            public double f()
            {
                return 0;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class CubicMicroState : MicroState
    {
        private MetricCubicVolume volume;

        public CubicMicroState(int n, double a, double depth)
        {
            this.nstates = n;
            this.angularmomentum = a;

            volume = new MetricCubicVolume(depth);

        }

        //public functions

        public double calculate_microstate()
        {
            volume.calculate(this);
            return delabeledVolume(nstates, volume.volume, angularmomentum);
        }

        
    }
}

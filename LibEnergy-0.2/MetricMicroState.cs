using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class MetricMicroState : MicroState
    {
        private MetricVolume volume;

        public MetricMicroState(int n, double a, double length, double width, double depth)
        {
            this.nstates = n;
            this.angularmomentum = a;

            volume = new MetricVolume(length, width, depth);
            
        }

        //public functions

        public double calculate_microstate()
        {
            volume.calculate(this);
            return delabeledVolume(nstates, volume.volume, angularmomentum);
        }
    }
}

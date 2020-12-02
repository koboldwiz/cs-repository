using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class VectorMicroState : MicroState
    {
        private VolumeVector volume;

        public VectorMicroState(int n, double a, double energy, double energydelta,
                double x, double dx,
                double y, double dy,
                double z, double dz,
                double thresholdx, double thresholdy, double thresholdz)
        { 
            this.nstates = n;
            this.angularmomentum = a;

            volume = new VolumeVector(energy, energydelta, x, dx, y, dy, z, dz, thresholdx, thresholdy, thresholdz);
        }

        //public functions

        public double calculate_microstate()
        {
            volume.calculate(this);
            return delabeledVolume(nstates, volume.volume, angularmomentum);
        }

       
    }
}

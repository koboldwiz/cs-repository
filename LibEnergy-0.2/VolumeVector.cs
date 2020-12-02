using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class VolumeVector : Volume
    {
        double energy, energydelta,
                x, dx,
                y, dy,
                z, dz,
                thresholdx, thresholdy, thresholdz;

        

        public VolumeVector(double energy, double energydelta,
                double x, double dx,
                double y, double dy,
                double z, double dz,
                double thresholdx, double thresholdy, double thresholdz)
        {
            this.energy = energy;
            this.energydelta = energydelta;
            this.x = x;
            this.dx = dx;
            this.y = y;
            this.dy = dy;
            this.z = z;
            this.thresholdx = thresholdx;
            this.thresholdy = thresholdy;
            this.thresholdz = thresholdz;
        }

        public override double calculate(MicroState ms)
        {
            volume = volumeVector(energy, energydelta, x, dx, y, dy, z, dz, thresholdx, thresholdy, thresholdz);

            return ms.calculate_volume(this);
        }

        public double volumeVector(double energy, double energydelta,
                double x, double dx,
                double y, double dy,
                double z, double dz,
                double thresholdx, double thresholdy, double thresholdz)
        /*
         * The integral for Volume = int(Gamma), scaled as a hyper volume in 3 dimensions
         */
        {
            double v = 0.0, vtmp = 0.0;
            double n = x;
            do
            {
                vtmp += n * (energy - energydelta);
                n += dx;
            } while (n < thresholdx);

            v = vtmp;

            n = y;
            do
            {
                vtmp += n * (energy - energydelta);
                n += dy;
            } while (n < thresholdy);

            v *= vtmp;

            n = z;
            do
            {
                vtmp += n * (energy - energydelta);
                n += dz;
            } while (n < thresholdz);
            v *= vtmp;
            return v;
        }
    }
}

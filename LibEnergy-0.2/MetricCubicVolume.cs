using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class MetricCubicVolume : Volume
    {
        private double depth;

        public MetricCubicVolume(double depth)
        {
            this.depth = depth;
        }

        public override double calculate(MicroState ms)
        {
            volume = metricCubicVolume(this.depth);

            return ms.calculate_volume(this);
        }

        /*
         * a volumetric Volume (cubic)
         *  Sigma(k^3) = [n(n + 1) / 2]^3
         */
        public double metricCubicVolume(double depth)
        {
            return Math.Pow((depth * depth + depth) / 2, 3);
        }
    }
}

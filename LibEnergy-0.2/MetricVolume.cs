using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class MetricVolume : Volume
    {
        private double length,width,depth;

        public MetricVolume(double length, double width, double depth)
        {
            this.length = length;
            this.width = width;
            this.depth = depth;
        }

        public override double calculate(MicroState ms)
        {
            volume = metricVolume(this.length, this.width, this.depth);

            return ms.calculate_volume(this);
        }

        /*
         * a volumetric Volume (cubic)
         *  Sigma(k^3) = [n(n + 1) / 2]^3
         */
        public double metricVolume(double length, double width, double depth)
        {
            return (length * length + length) / 2 * (width * width + width) / 2 * (depth * depth + depth) / 2;
        }
    }
}

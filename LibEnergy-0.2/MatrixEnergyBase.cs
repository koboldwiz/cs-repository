using System;
using System.Collections.Generic;
using System.Text;


namespace Energy_cs
{
    class MatrixEnergyBase
    {
        protected Matrixnm matrix { get; set; }

        public MatrixEnergyBase()
        {
        }

        public MatrixEnergyBase(Matrixnm m)
        {

            matrix = m;

        }
    }
}

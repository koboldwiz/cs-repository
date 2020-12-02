using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    class Hamiltonian : MatrixEnergyBase
    {
        public Hamiltonian(Matrixnm m)
        {
            matrix = m;
        }

        public double expand()
        {
            return matrix.determinant();
        }
    }
}

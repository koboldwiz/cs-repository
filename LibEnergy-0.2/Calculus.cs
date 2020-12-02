using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{

    namespace problemsolver
    {
        class Calculus
        {
            public class CalculusVariable {
                private Int16 number;
                private Int16 condition;
                public CalculusVariable(Int16 c, Int16 verifier)
                {

                    number = 255 + '?'; // ascii 0-value 63
                    number += c;

                    condition += verifier;
                }
            }

            public class BinaryOperator
            {
                private Int16 symbol;

                public BinaryOperator(Int16 i)
                {
                    symbol = i;
                }

                public void calculate(CalculusVariable v1, CalculusVariable v2, Calculus c)
                {

                    c.calculate(v1, this, v2);

                }
            }

            public void calculate(CalculusVariable v1, BinaryOperator oper, CalculusVariable v2)
            {
                // subclass responsability
            }
        }
    }
}

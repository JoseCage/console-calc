using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Components
{
    class Subtracao
    {
        public int val1;
        public int val2;

        public Subtracao() { }

        public int Subtrair(int val1, int val2)
        {
            return val1 - val2;
        }
    }
}

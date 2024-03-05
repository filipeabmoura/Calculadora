using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp.model
{
    public class Soma: IOperacao
    {
        public Soma() { }

        public int calcular(int a, int b)
        {
            return a + b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp.model
{
    public interface IOperacao
    {
        public int calcular(int a, int b);
    }
}

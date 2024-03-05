using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp.model
{
    public class Divisao: IOperacao
    {
        public Divisao() { }

        public int calcular(int a, int b)
        {
            if(b == 0)
            {
                //tem uma exceção específica? pesquisar depois
                throw new Exception("Divisão por zero");
            }

            return a / b;
        }
    }
}

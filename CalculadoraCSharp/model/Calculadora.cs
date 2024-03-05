using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp.model
{
    public class Calculadora
    {
        public Calculadora() { }

        public int calcular(String operacao, int a, int b)
        {
            IOperacao op = null;

            if (operacao.Equals("Soma"))
            {
                op = new Soma();
            }

            if (operacao.Equals("Subtracao"))
            {
                op = new Subtracao();
            }

            if (operacao.Equals("Multiplicacao"))
            {
                op = new Multiplicacao();
            }

            if (operacao.Equals("Divisao"))
            {
                op = new Divisao();
            }

            if (op == null)
            {
                //tem uma exceção específica? pesquisar depois
                throw new Exception("Operação Inválida");
            }
            return op.calcular(a, b);
        }
    }
}

using CalculadoraCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp.controller
{
    public class ControladorCalculadora
    {
        public int calcular(string operacao, int a, int b)
        {

            Calculadora calc = new Calculadora();
            return calc.calcular(operacao, a, b);
        }
    }
}

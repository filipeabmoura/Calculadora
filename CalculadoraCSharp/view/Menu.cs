using CalculadoraCSharp.controller;
using CalculadoraCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp.view
{
    public class Menu
    {
        public Menu() { }

        public void exibir()
        {

            Console.WriteLine("Soma");
            Console.WriteLine("Subtracao");
            Console.WriteLine("Multiplicacao");
            Console.WriteLine("Divisao");
            Console.WriteLine("Sair\n");

            Console.WriteLine("Digite a Operação Desejada: ");
            string operacao = Console.ReadLine();

            while (operacao != "Soma" && operacao != "Subtracao" && operacao != "Multiplicacao" && operacao != "Divisao")
            {
               Console.WriteLine("\nOperação Inválida\nDigite a Operação Desejada Novamente\n");
               operacao = Console.ReadLine();
            }

            Console.WriteLine("\nDigite o Primeiro Valor");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Segundo Valor");
            int b = int.Parse(Console.ReadLine());

            ControladorCalculadora control = new ControladorCalculadora();

            int resultado = control.calcular(operacao, a, b);

            Console.WriteLine($"\nResultado: {resultado}");
        }
    }
}

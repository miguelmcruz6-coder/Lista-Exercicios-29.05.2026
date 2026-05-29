using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Desafio4
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"Resultado: {a + b}");
        }
        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"Resultado: {a - b}");
        }
        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"Resultado: {a * b}");
        }
        public void Dividir(int a, int b)
        {
            Console.Write("Resultado: ");
            if (b == 0)
            {
                Console.WriteLine("Divisão Impossível");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
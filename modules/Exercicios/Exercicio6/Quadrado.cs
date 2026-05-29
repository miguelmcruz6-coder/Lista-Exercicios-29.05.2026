using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio6
{
    public class Quadrado : Forma, IDesenho
    {
        public double Lado { get; set; }
        public override double CalcularArea()
        {
            return (Lado * Lado);
        }

        public void Desenhar()
        {
            Console.WriteLine("Digite o valor do lado do quadrado que deseja fazer");
            Lado = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Quadrado desenhado");
        }
    }
}
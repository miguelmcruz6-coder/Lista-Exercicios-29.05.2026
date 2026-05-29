using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio6
{
    public class Circulo : Forma, IDesenho
    {
        public double Raio { get; set; }
        public override double CalcularArea()
        {
            return (3.14 * (Raio * Raio));
        }

        public void Desenhar()
        {
            Console.WriteLine("Digite o raio do círculo que deseja fazer");
            Raio = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Círculo desenhado");
        }
    }
}
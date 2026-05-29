using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio6
{
    public class Retangulo : Forma, IDesenho
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public override double CalcularArea()
        {
            return (Altura * Largura);
        }

        public void Desenhar()
        {
            Console.WriteLine("Digite a largura do retângulo que deseja fazer");
            Largura = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a altura do retângulo que deseja fazer");
            Altura = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Retângulo desenhado");
        }
    }
}
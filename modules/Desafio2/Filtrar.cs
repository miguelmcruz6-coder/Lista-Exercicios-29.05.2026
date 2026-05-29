using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Desafio2
{
    public class Filtrar
    {
        public int Posicao { get; set; }
        public void Maior100()
        {
            double maior = -999999999;
            for (int i = 0; i < 100; i++)
            {
                double n = double.Parse(Console.ReadLine()!);
                if (n > maior)
                {
                    maior = n;
                    Posicao = i + 1;
                }
            }
            Console.WriteLine($"Maior número digitado: {maior}");
            Console.WriteLine($"Posição do maior número digitado: {Posicao}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio1
{
    public class Moto : Veiculo, IBuzina
    {
        public override int Aceleracao { get; set; } = 10;
        public void Buzinar()
        {
            Console.WriteLine("Bip");
        }
    }
}
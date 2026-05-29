using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio4
{
    public class Vaca : Animal, IComportamento
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Mooooooooo");
        }
        public void Comer()
        {
            Console.WriteLine("A vaca está comendo...");
        }
        public void Dormir()
        {
            Console.WriteLine("A vaca está dormindo...");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio4
{
    public class Cachorro : Animal, IComportamento
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au!");
        }
        public void Comer()
        {
            Console.WriteLine("O cachorro está comendo...");
        }
        public void Dormir()
        {
            Console.WriteLine("O cachorro está dormindo...");
        }
    }
}
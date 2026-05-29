using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio4
{
    public class Gato : Animal, IComportamento
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Meow");
        }
        public void Comer()
        {
            Console.WriteLine("O gato está comendo...");
        }
        public void Dormir()
        {
            Console.WriteLine("O gato está dormindo...");
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Selar
{
    public /*sealed*/ class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override /*sealed*/ void Apresentar()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Classe: Professor");
        }
    }
}
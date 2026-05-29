using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio4
{
    public abstract class Animal
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public abstract void EmitirSom();
    }
}
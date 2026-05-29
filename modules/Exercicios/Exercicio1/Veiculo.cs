using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio1
{
    public abstract class Veiculo
    {
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public abstract int Aceleracao { get; set; }
        public decimal VelocidadeAtual { get; set; }
        public void Acelerar(decimal aumentar)
        {
            for(int i = 0; i < aumentar; i++)
            {
                VelocidadeAtual += Aceleracao;
            }
        }
        public void Frear(decimal diminuir)
        {
            VelocidadeAtual -= diminuir;
            if(VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }
    }
}
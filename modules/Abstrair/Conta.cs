using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Abstrair
{
    public abstract class Conta
    {
        public double Saldo { get; set; }
        public abstract void Creditar(double valor);

        public virtual void ExibirSaldo()
        {
            Console.WriteLine("Exibir Saldo");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Abstrair
{
    public class Corrente : Conta
    {
        private double Tarifa { get; set; }

        public override void Creditar(double valor)
        {
            Saldo += (Saldo - Tarifa);
        }

        public override void ExibirSaldo()
        {
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
}
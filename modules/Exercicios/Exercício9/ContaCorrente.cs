using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício9
{
    public class ContaCorrente : Conta, ITransferencia
    {
        public ContaCorrente(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }
        public override double CalcularTaxa()
        {
            Saldo -= 0.10; // Taxa fixa de R$0,10 por operação
            return 0.10;
        }
        public override void MostrarExtrato()
        {
            Console.WriteLine($"Extrato da Conta Corrente de {Titular}:\n");
            foreach (var extrato in extratos)
            {
                Console.WriteLine($"{extrato.Data}: {extrato.Tipo} - R${extrato.Valor:F2}");
            }
            Console.WriteLine($"Saldo atual: R${Saldo:F2}\n");
        }
    }
}
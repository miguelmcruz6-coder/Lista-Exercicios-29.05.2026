using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício9
{
    public abstract class Conta
    {
        public string Titular { get; set; } = string.Empty;
        protected double Saldo { get; protected set; }
        protected List<Extrato> extratos { get; set; }

        public Conta(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
            extratos = new List<Extrato>();
        }

        public virtual void Sacar(double valor)
        {
            if (Saldo >= valor + CalcularTaxa())
            {
                Saldo -= valor;
                CalcularTaxa();
                Extrato extrato = new Extrato
                {
                    Data = DateTime.Now,
                    Tipo = "Saque",
                    Valor = valor + CalcularTaxa()
                };
                extratos.Add(extrato);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Extrato extrato = new Extrato
                {
                    Data = DateTime.Now,
                    Tipo = "Depósito",
                    Valor = valor
                };
                extratos.Add(extrato);
        }
        public double ConsultarSaldo()
        {
            return Saldo;
        }
        public abstract void MostrarExtrato();
        public abstract double CalcularTaxa();
    }
}
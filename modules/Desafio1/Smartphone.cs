using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Desafio1
{
    public abstract class Smartphone
    {
        public string Nome { get; set; } = string.Empty;
        private string Modelo { get; set; } = string.Empty;
        private string IMEI { get; set; } = string.Empty;
        private int Memoria { get; set; }
        public void Ligar()
        {
            Console.WriteLine("Ligando");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Ligação Recebida");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}
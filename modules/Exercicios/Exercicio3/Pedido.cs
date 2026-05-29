using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio3
{
    public abstract class Pedido
    {
        public double Numero { get; set; }
        public double Valor { get; set; }
        public abstract void FinalizarPedido();
    }
}
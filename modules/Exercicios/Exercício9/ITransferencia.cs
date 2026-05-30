using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício9
{
    public interface ITransferencia
    {
        void Transferir(Conta contaDestino, double valor);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio3
{
    public class PedidoOnline : Pedido, IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine("Digite o número ao lado de uma das opções abaixo");
            Console.WriteLine("1 - Cartao de Crédito");
            Console.WriteLine("2 - Pix");
            string resposta = Console.ReadLine()!;
            bool respostaCorreta = true;
            switch (resposta)
            {
                case "1":
                    Console.WriteLine("Cartao de Crédito selecionado!");
                    break;
                case "2":
                    Console.WriteLine("Pix selecionado!");
                    break;
                default:
                    Console.WriteLine("Brinque menos na próxima");
                    respostaCorreta = false;
                    break;
            }
            if (respostaCorreta)
            {
                Console.WriteLine($"Valor total a pagar: R${valor}");
                FinalizarPedido();
            }
        }
        public override void FinalizarPedido()
        {
            Console.WriteLine("Pedido finalizado com sucesso! Agradeçemos a preferência");
        }
    }
}
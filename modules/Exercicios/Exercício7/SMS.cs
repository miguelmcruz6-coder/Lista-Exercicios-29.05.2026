using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício7
{
    public class SMS : Usuario, INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando SMS para {Nome}: {mensagem}");
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Dados do usuário {Nome}, Telefone: {Telefone}, Tipo: SMS");
        }
    }
}
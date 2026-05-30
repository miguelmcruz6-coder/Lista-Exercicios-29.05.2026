using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio5
{
    public class UsuarioComum : PessoaSistema
    {
        public UsuarioComum(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
        public override void ExibirPermissao()
        {
            Console.WriteLine("Usuário comum: Permissão limitada.");
        }
    }
}
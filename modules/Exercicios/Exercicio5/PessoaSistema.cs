using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio5
{
    public abstract class PessoaSistema : IAutenticacao
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public abstract void ExibirPermissao();
        public bool Autenticar(string nome, string senha)
        {
            if(this.Nome == nome && this.Senha == senha)
            {
                return true;
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio2
{
    public abstract class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        protected decimal SalarioBase { get; set; }
        public abstract decimal CalcularSalario();
        public void ColocarSalario(decimal novoSalario)
        {
            SalarioBase = novoSalario;
        }
    }
}
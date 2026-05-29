using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio2
{
    public class Estagiario : Funcionario, IRelatorio
    {
        public override decimal CalcularSalario()
        {
            return SalarioBase;
        }
        public void ExibirRelatorio()
        {
            Console.WriteLine($"Nome: {Nome}\nTrabalho: Desenvolvedor\nSalário: R${CalcularSalario()}");
        }
    }
}
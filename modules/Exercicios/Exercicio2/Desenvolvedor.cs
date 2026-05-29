using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio2
{
    public class Desenvolvedor : Funcionario, IRelatorio
    {
        public override decimal CalcularSalario()
        {
            return ((SalarioBase / 100) * 110);
        }
        public void ExibirRelatorio()
        {
            Console.WriteLine($"Nome: {Nome}\nTrabalho: Desenvolvedor\nSalário: R${CalcularSalario()}");
        }
    }
}
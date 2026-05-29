using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercicio2
{
    public class Gerente : Funcionario, IRelatorio
    {
        public override decimal CalcularSalario()
        {
            return ((SalarioBase / 100) * 120);
        }
        public void ExibirRelatorio()
        {
            Console.WriteLine($"Nome: {Nome}\nTrabalho: Gerente\nSalário: R${CalcularSalario()}");
        }
    }
}
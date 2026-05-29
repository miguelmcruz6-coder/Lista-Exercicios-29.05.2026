using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Interfaces
{
    public interface ICalculadora
    {
        public double Resultado { get; set; }
        double Somar(int a, int b);
        double Subtrair(int a, int b);
        double Multiplicar(int a, int b);
        double Dividir(int a, int b);
    }
}
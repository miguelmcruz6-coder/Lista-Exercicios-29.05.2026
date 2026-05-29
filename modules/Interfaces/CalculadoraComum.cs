using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Interfaces
{
    public class CalculadoraComum : ICalculadora
    {
        public double Resultado { get; set; }
        public double Somar(int a, int b)
        {
            if(Resultado == 0)
            {
                Resultado = a + b;
            }
            else
            {
                Resultado += a;
            }
            return Resultado;
        }
        public double Subtrair(int a, int b)
        {
            if(Resultado == 0)
            {
                Resultado = a + b;
            }
            else
            {
                Resultado -= a;
            }
            return Resultado;
        }
        public double Multiplicar(int a, int b)
        {
            if(Resultado == 0)
            {
                Resultado = a * b;
            }
            else
            {
                Resultado *= a;
            }
            return Resultado;
        }
        public double Dividir(int a, int b)
        {
            if(Resultado == 0)
            {
                Resultado += a / b;
            }
            else
            {
                Resultado /= a;
            }
            return Resultado;
        }
    }
}
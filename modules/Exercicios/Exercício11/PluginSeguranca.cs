using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício11
{
    public class PluginSeguranca : IPlugin
    {
        protected bool funcionando = false;
        public void Executar()
        {
            Console.WriteLine("Executando plugin de segurança...");
            funcionando = true;
        }
        public void Encerrar()
        {
            Console.WriteLine("Encerrando plugin de segurança...");
            funcionando = false;
        }
    }
}
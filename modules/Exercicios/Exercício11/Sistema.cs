using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício11
{
    public class Sistema
    {
        protected List<IPlugin> plugins
        {
            get
            {
                return new List<IPlugin>
                {
                    new PluginAudio(),
                    new PluginVideo(),
                    new PluginSeguranca()
                };
            }
        }
        public void ExecutarPlugin(int indice)
        {
            if (indice >= 0 && indice < plugins.Count)
            {
                if (!plugins[indice].funcionando)
                {
                    plugins[indice].Executar();
                    return;
                }
                else
                {
                    Console.WriteLine("O plugin já está funcionando.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Índice de plugin inválido.");
            }
        }
        public void ExecutarTudo()
        {
            foreach (var plugin in plugins)
            {
                plugin.Executar();
            }
        }
        public void EncerrarPlugin(int indice)
        {
            if (indice >= 0 && indice < plugins.Count)
            {
                if (plugins[indice].funcionando)
                {
                    plugins[indice].Encerrar();
                    return;
                }
                else
                {
                    Console.WriteLine("O plugin já está encerrado.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Índice de plugin inválido.");
            }
        }
        public void EncerrarTudo()
        {
            foreach (var plugin in plugins)
            {
                plugin.Encerrar();
            }
        }
    }
}
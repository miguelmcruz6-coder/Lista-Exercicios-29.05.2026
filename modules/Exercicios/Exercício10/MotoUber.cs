using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício10
{
    public class MotoUber : VeiculoAplicativo, ILocalizacao
    {
        public override double CalcularCorrida(double distancia)
        {
            Historico historico = new Historico
            {
                Data = DateTime.Now,
                Distancia = distancia,
                Valor = distancia * 1.5
            };
            HistoricoCorridas.Add(historico);
            QuilometrosRodados += distancia;
            return distancia * 1.5;
        }
        public void AtualizarLocalizacao()
        {
            Console.WriteLine("Localização da Moto atualizada.");
        }
    }
}
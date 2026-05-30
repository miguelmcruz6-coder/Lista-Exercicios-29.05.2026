using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício10
{
    public abstract class VeiculoAplicativo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public double QuilometrosRodados { get; set; }
        protected List<Historico> HistoricoCorridas { get; set; }
        public abstract double CalcularCorrida(double distancia);
    }
}
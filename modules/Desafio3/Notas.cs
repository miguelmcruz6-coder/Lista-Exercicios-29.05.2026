using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Desafio3
{
    public class Notas
    {
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Media { get; set; }
        public void FazerMedia()
        {
            Media = ((Nota1 * 2) + (Nota2 * 3) + (Nota3 * 5)) / 10;
        }
    }
}
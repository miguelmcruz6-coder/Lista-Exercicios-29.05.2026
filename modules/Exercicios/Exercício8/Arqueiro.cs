using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício8
{
    public class Arqueiro : Personagem, IHabilidadeEspecial
    {
        public Arqueiro(string nome)
        {
            Nome = nome;
            Vida = 120;
            Ataque = random.Next(12, 20);
        }
        public void UsarHabilidade()
        {
            Console.WriteLine("O arqueiro usa sua habilidade especial!");
            Atacar(Ataque + 15);
        }
        public override void Atacar(int dano)
        {
            Console.WriteLine($"{Nome} dispara uma flecha, causando {Ataque} de dano!");
        }
    }
}
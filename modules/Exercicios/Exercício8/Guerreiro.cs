using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício8
{
    public class Guerreiro : Personagem, IHabilidadeEspecial
    {
        public Guerreiro(string nome)
        {
            Nome = nome;
            Vida = 150;
            Ataque = random.Next(18, 30);
        }
        public void UsarHabilidade()
        {
            Console.WriteLine("O guerreiro usa sua habilidade especial!");
            Atacar(Ataque + 15);
        }
        public override void Atacar(int dano)
        {
            Console.WriteLine($"{Nome} ataca com força total, causando {Ataque} de dano!");
        }
    }
}
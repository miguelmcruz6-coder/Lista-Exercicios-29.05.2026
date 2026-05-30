using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício8
{
    public class Mago : Personagem, IHabilidadeEspecial
    {
        public Mago(string nome)
        {
            Nome = nome;
            Vida = 100;
            Ataque = random.Next(19, 30);
        }
        public void UsarHabilidade()
        {
            Console.WriteLine("O mago usa sua habilidade especial!");
            Atacar(Ataque + 15);
        }
        public override void Atacar(int dano)
        {
            Console.WriteLine($"{Nome} lança um feitiço, causando {Ataque} de dano!");
        }
    }
}
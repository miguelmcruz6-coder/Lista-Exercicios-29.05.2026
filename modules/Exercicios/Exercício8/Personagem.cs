using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_POO_28._05._2026.modules.Exercicios.Exercício8
{
    public abstract class Personagem
    {
        public string Nome { get; set; } = string.Empty;
        public int Vida { get; set; }
        public int Ataque { get; set; }
        Random random = new Random();
        public abstract void Atacar(int dano);
        public void ReceberDano(int dano)
        {
            Vida -= dano;
            if(Vida < 0)
            {
                Vida = 0;
                Console.WriteLine($"{Nome} foi derrotado!");
            }
            else
            {
                Console.WriteLine($"{Nome} recebeu {dano} de dano, vida restante: {Vida}");
            }
        }
    }
}
// =====================================================================
//                          Locais
// =====================================================================

// -----------------------------------------------------
//    Desafios
// -----------------------------------------------------

using Aula_POO_28._05._2026.modules.Desafio2;
using Aula_POO_28._05._2026.modules.Desafio3;
using Aula_POO_28._05._2026.modules.Desafio4;
using Aula_POO_28._05._2026.modules.Exercicios.Exercicio1;
using Aula_POO_28._05._2026.modules.Exercicios.Exercicio2;
using Aula_POO_28._05._2026.modules.Exercicios.Exercicio3;
using Aula_POO_28._05._2026.modules.Exercicios.Exercicio4;
using Aula_POO_28._05._2026.modules.Exercicios.Exercicio6;

// -----------------------------------------------------
//    Exercícios
// -----------------------------------------------------



// =====================================================================
//      Desafio 2
// =====================================================================

Filtrar filtrar = new Filtrar();
filtrar.Maior100();

// =====================================================================
//      Desafio 3
// =====================================================================

Notas notas = new Notas();

Console.WriteLine("Digite a primeira nota");
Console.Write("Nota 1: ");
notas.Nota1 = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a segunda nota");
Console.Write("Nota 2: ");
notas.Nota2 = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a terceira nota");
Console.Write("Nota 3: ");
notas.Nota3 = decimal.Parse(Console.ReadLine()!);

notas.FazerMedia();
Console.WriteLine($"Média: {notas.Media}");

// =====================================================================
//      Desafio 4
// =====================================================================

Calculadora calculadora = new Calculadora();

Console.WriteLine("Digite um número");
int numero1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite outro número");
int numero2 = int.Parse(Console.ReadLine()!);

calculadora.Dividir(numero1, numero2);

// =====================================================================
//                         Lista de Exercícios
// =====================================================================

// -----------------------------------------------------
//    Exercício 1
// -----------------------------------------------------

Carro carro = new Carro();
carro.Marca = "a";
carro.Modelo = "a";
carro.VelocidadeAtual = 50;

Console.WriteLine("Velocidade: " + carro.VelocidadeAtual);
carro.Acelerar(3);
Console.WriteLine("Velocidade: " + carro.VelocidadeAtual);
carro.Frear(100);
Console.WriteLine("Velocidade: " + carro.VelocidadeAtual);
carro.Buzinar();

Moto moto = new Moto();
moto.Marca = "b";
moto.Modelo = "b";
moto.VelocidadeAtual = 50;

Console.WriteLine("Velocidade: " + moto.VelocidadeAtual);
moto.Acelerar(3);
Console.WriteLine("Velocidade: " + moto.VelocidadeAtual);
moto.Frear(100);
Console.WriteLine("Velocidade: " + moto.VelocidadeAtual);
moto.Buzinar();

// -----------------------------------------------------
//    Exercício 2
// -----------------------------------------------------

Gerente gerente = new Gerente();

gerente.Nome = "Alberto";
gerente.ColocarSalario(5000);
gerente.ExibirRelatorio();

Desenvolvedor desenvolvedor = new Desenvolvedor();

desenvolvedor.Nome = "Alberto";
desenvolvedor.ColocarSalario(3000);
desenvolvedor.ExibirRelatorio();

Estagiario estagiario = new Estagiario();

estagiario.Nome = "Alberto";
estagiario.ColocarSalario(1300);
estagiario.ExibirRelatorio();

// -----------------------------------------------------
//    Exercício 3
// -----------------------------------------------------

PedidoLoja pedidoLoja = new PedidoLoja();

pedidoLoja.Numero = 5;
pedidoLoja.Valor = 100;
double produto = pedidoLoja.Numero * pedidoLoja.Valor;
pedidoLoja.Pagar(produto);

PedidoOnline pedidoOnline = new PedidoOnline();

pedidoOnline.Numero = 7;
pedidoOnline.Valor = 120;
produto = pedidoOnline.Numero * pedidoOnline.Valor;
pedidoOnline.Pagar(produto);

// -----------------------------------------------------
//    Exercício 4 -- Incompleto
// -----------------------------------------------------

Cachorro cachorro = new Cachorro();

cachorro.EmitirSom();
cachorro.Comer();
cachorro.Dormir();

Gato gato = new Gato();

gato.EmitirSom();
gato.Comer();
gato.Dormir();

Vaca vaca = new Vaca();

vaca.EmitirSom();
vaca.Comer();
vaca.Dormir();

// -----------------------------------------------------
//    Exercício 5 -- Incompleto
// -----------------------------------------------------










// -----------------------------------------------------
//    Exercício 6 -- Incompleto
// -----------------------------------------------------

bool continuar = true;

List<Quadrado> listaQuadrados = new List<Quadrado>();
List<Retangulo> listaRetangulos = new List<Retangulo>();
List<Circulo> listaCirculos = new List<Circulo>();

while (continuar)
{
    Console.WriteLine("Digite uma das opções desejadas abaixo");
    Console.WriteLine("1 - Desenhar");
    Console.WriteLine("2 - Mostrar Área");
    Console.WriteLine("3 - Sair");
    string resposta = Console.ReadLine()!;
    switch (resposta)
    {
        case "1":
            Console.WriteLine("Digite o número ao lado da figura desejada");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Retangulo");
            Console.WriteLine("3 - Circulo");
            string respostaDesenho = Console.ReadLine()!;
            switch (respostaDesenho)
            {
                case "1":
                    Quadrado quadrado = new Quadrado();
                    quadrado.Desenhar();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }
            break;
        case "2":
            break;
        case "3":
            break;
        default:
            break;
    }
}






// -----------------------------------------------------
//    Exercício 7 -- Incompleto
// -----------------------------------------------------










// -----------------------------------------------------
//    Exercício 8 -- Incompleto
// -----------------------------------------------------










// -----------------------------------------------------
//    Exercício 9 -- Incompleto
// -----------------------------------------------------










// -----------------------------------------------------
//    Exercício 10 -- Incompleto
// -----------------------------------------------------










// -----------------------------------------------------
//    Exercício 11 -- Incompleto
// -----------------------------------------------------














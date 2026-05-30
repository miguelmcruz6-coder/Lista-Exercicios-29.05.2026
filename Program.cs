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
//    Exercício 4
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

Console.WriteLine("Digite o nome do usuário");
string nome = Console.ReadLine()!;
Console.WriteLine("Digite o email do usuário");
string email = Console.ReadLine()!;
Console.WriteLine("Digite a senha do usuário");
string senha = Console.ReadLine()!;

Admin admin = new Admin(nome, email, senha);

for(int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o nome do usuário para autenticação");
    string nomeAutenticacao = Console.ReadLine()!;
    Console.WriteLine("Digite a senha do usuário para autenticação");
    string senhaAutenticacao = Console.ReadLine()!;
    if(admin.Autenticar(nomeAutenticacao, senhaAutenticacao))
    {
        Console.WriteLine("Autenticação bem-sucedida!");
        admin.ExibirPermissao();
        break;
    }
    else
    {
        Console.WriteLine("Falha na autenticação. Nome ou senha incorretos.");
        if (i == 2)
        {
            Console.WriteLine("Número máximo de tentativas atingido. Acesso bloqueado.");
        }
    }
}

Console.WriteLine("Digite o nome de outro usuário");
nome = Console.ReadLine()!;
Console.WriteLine("Digite o email de outro usuário");
email = Console.ReadLine()!;
Console.WriteLine("Digite a senha de outro usuário");
senha = Console.ReadLine()!;

UsuarioComum usuarioComum = new UsuarioComum(nome, email, senha);

for(int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o nome deste novo usuário para autenticação");
    string nomeAutenticacao = Console.ReadLine()!;
    Console.WriteLine("Digite a senha deste novo usuário para autenticação");
    string senhaAutenticacao = Console.ReadLine()!;
    if(usuarioComum.Autenticar(nomeAutenticacao, senhaAutenticacao))
    {
        Console.WriteLine("Autenticação bem-sucedida!");
        usuarioComum.ExibirPermissao();
        break;
    }
    else
    {
        Console.WriteLine("Falha na autenticação. Nome ou senha incorretos.");
        if (i == 2)
        {
            Console.WriteLine("Número máximo de tentativas atingido. Acesso bloqueado.");
        }
    }
}

// -----------------------------------------------------
//    Exercício 6
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
                    Retangulo retangulo = new Retangulo();
                    retangulo.Desenhar();
                    break;
                case "3":
                    Circulo circulo = new Circulo();
                    circulo.Desenhar();
                    break;
                default:
                    break;
            }
            break;

        case "2":
            if (listaQuadrados.Count == 0 && listaRetangulos.Count == 0 && listaCirculos.Count == 0)
            {
                Console.WriteLine("Nenhuma figura foi desenhada ainda");
                break;
            }
            if (listaQuadrados.Count > 0)
            {
                Console.WriteLine("Quadrados:");
                foreach (Quadrado quadrado in listaQuadrados)
                {
                    Console.WriteLine($"Área do quadrado: {quadrado.CalcularArea()}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum quadrado foi desenhado ainda");
            }

            if (listaRetangulos.Count > 0)
            {
                Console.WriteLine("Retângulos:");
                foreach (Retangulo retangulo in listaRetangulos)
                {
                    Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum retângulo foi desenhado ainda");
            }

            if (listaCirculos.Count > 0)
            {
                Console.WriteLine("Círculos:");
                foreach (Circulo circulo in listaCirculos)
                {
                    Console.WriteLine($"Área do círculo: {circulo.CalcularArea()}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum círculo foi desenhado ainda");
            }
            break;

        case "3":
            continuar = false;
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }
}

// -----------------------------------------------------
//    Exercício 7
// -----------------------------------------------------

continuar = true;
Console.WriteLine("Digite o nome do usuário");
string nome = Console.ReadLine()!;
Console.WriteLine("Digite o telefone do usuário");
string telefone = Console.ReadLine()!;

Console.WriteLine("Digite o tipo de notificação desejada");
Console.WriteLine("1 - E-mail");
Console.WriteLine("2 - SMS");
Console.WriteLine("3 - WhatsApp");
string tipoNotificacao = Console.ReadLine()!;
bool contaCriada = true;

switch (tipoNotificacao)
{
    case "1":
        Email conta = new Email();
        break;
    case "2":
        SMS conta = new SMS();
        break;
    case "3":
        Whatsapp conta = new WhatsApp();
        break;
    default:
        Console.WriteLine("Tipo de notificação inválida, usuário não criado");
        contaCriada = false;
        break;
}

if (contaCriada)
{
    conta.Nome = nome;
    conta.Telefone = telefone;
    conta.EnviarMensagem("Esta é uma mensagem de teste.");
    while (continuar)
    {
        Console.WriteLine("Digite uma das opções desejadas abaixo");
        Console.WriteLine("1 - Enviar mensagem");
        Console.WriteLine("2 - Exibir dados do usuário");
        Console.WriteLine("3 - Sair");
        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                notificacao.EnviarMensagem("\t\tEsta é uma mensagem de teste.");
                Console.Write("Escreva uma mensagem: ");
                string mensagem = Console.ReadLine()!;
                notificacao.EnviarMensagem(mensagem);
                break;
            case "2":
                conta.ExibirDados();
                break;
            case "3":
                continuar = false;
                break;
            default:
                Console.WriteLine("Opção inválida, tente novamente");
                break;
        }
    }
}

// -----------------------------------------------------
//    Exercício 8
// -----------------------------------------------------

Console.WriteLine("Digite o nome do personagem");
string nomePersonagem = Console.ReadLine()!;

Console.WriteLine("Digite a classe do personagem que deseja criar");
Console.WriteLine("1 - Guerreiro");
Console.WriteLine("2 - Mago");
Console.WriteLine("3 - Arqueiro");
string classePersonagem = Console.ReadLine()!;
bool personagemCriado1 = true;

switch (classePersonagem)
{
    case "1":
        Guerreiro usuario = new Guerreiro(nomePersonagem);
        break;
    case "2":
        Mago usuario = new Mago(nomePersonagem);
        break;
    case "3":
        Arqueiro usuario = new Arqueiro(nomePersonagem);
        break;
    default:
        Console.WriteLine("Classe inválida, personagem não criado");
        personagemCriado = false;
        break;
}

Console.WriteLine("Digite o nome do personagem");
nomePersonagem = Console.ReadLine()!;

Console.WriteLine("Digite a classe do personagem que deseja enfrentar");
Console.WriteLine("1 - Guerreiro");
Console.WriteLine("2 - Mago");
Console.WriteLine("3 - Arqueiro");
string classePersonagem = Console.ReadLine()!;
bool personagemCriado2 = true;

switch (classePersonagem)
{
    case "1":
        Guerreiro adversario = new Guerreiro(nomePersonagem);
        break;
    case "2":
        Mago adversario = new Mago(nomePersonagem);
        break;
    case "3":
        Arqueiro adversario = new Arqueiro(nomePersonagem);
        break;
    default:
        Console.WriteLine("Classe inválida, personagem não criado");
        personagemCriado = false;
        break;
}

if (personagemCriado1 && personagemCriado2)
{
    int tempoDeRecarga = 0;
    Console.WriteLine("Batalha iniciada!");
    while (usuario.Vida > 0 && adversario.Vida > 0)
    {
        tempoDeRecarga--;
        Console.WriteLine("Digite uma das opções desejadas abaixo");
        Console.WriteLine("1 - Atacar");
        Console.WriteLine("2 - Usar habilidade especial");
        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                usuario.Atacar(adversario.Ataque);
                adversario.ReceberDano(usuario.Ataque);
                break;
            case "2":
                if (tempoDeRecarga <= 0)
                {
                    usuario.UsarHabilidade();
                    tempoDeRecarga = 2;
                }
                else
                {
                    Console.WriteLine("Habilidade em recarga!");
                }
                break;
            default:
                Console.WriteLine("Opção inválida, turno perdido!");
                break;
        }

        if (adversario.Vida <= 0)
        {
            break;
        }

        adversario.Atacar(usuario.Ataque);
        usuario.ReceberDano(adversario.Ataque);
        if (usuario.Vida <= 0)
        {
            break;
        }

        adversario.Atacar(usuario.Ataque);
        usuario.ReceberDano(adversario.Ataque);
    }
    if (usuario.Vida > 0)
    {
        Console.WriteLine($"{usuario.Nome} venceu a batalha!");
    }
    else
    {
        Console.WriteLine($"{adversario.Nome} venceu a batalha!");
    }
}

// -----------------------------------------------------
//    Exercício 9
// -----------------------------------------------------

continuar = true;
Console.WriteLine("Digite o nome do titular da conta corrente");
string nomeTitular = Console.ReadLine()!;

Console.WriteLine("Digite o saldo inicial da conta corrente");
double saldoInicial = double.Parse(Console.ReadLine()!);

ContaCorrente contaCorrente = new ContaCorrente(nomeTitular, saldoInicial);

while (continuar)
{
    Console.WriteLine("Digite uma das opções desejadas abaixo");
    Console.WriteLine("1 - Sacar");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Consultar saldo");
    Console.WriteLine("4 - Mostrar extrato");
    Console.WriteLine("5 - Sair");
    string opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o valor que deseja sacar");
            double valorSaque = double.Parse(Console.ReadLine()!);
            contaCorrente.Sacar(valorSaque);
            break;
        case "2":
            Console.WriteLine("Digite o valor que deseja depositar");
            double valorDeposito = double.Parse(Console.ReadLine()!);
            contaCorrente.Depositar(valorDeposito);
            break;
        case "3":
            double saldo = contaCorrente.ConsultarSaldo();
            Console.WriteLine($"Saldo atual: R${saldo:F2}");
            break;
        case "4":
            contaCorrente.MostrarExtrato();
            break;
        case "5":
            continuar = false;
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }
}

// -----------------------------------------------------
//    Exercício 10
// -----------------------------------------------------

continuar = true;

CarroUber carroUber = new CarroUber();
MotoUber motoUber = new MotoUber();

while (continuar)
{
    Console.WriteLine("Digite uma das opções desejadas abaixo");
    Console.WriteLine("1 - Calcular corrida de carro");
    Console.WriteLine("2 - Calcular corrida de moto");
    Console.WriteLine("3 - Histórico do carro");
    Console.WriteLine("4 - Histórico da moto");
    Console.WriteLine("5 - Atualizar localização do carro");
    Console.WriteLine("6 - Atualizar localização da moto");
    Console.WriteLine("7 - Sair");
    string opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a distância da corrida em km");
            double distanciaCarro = double.Parse(Console.ReadLine()!);
            if (distanciaCarro <= 0)
            {
                Console.WriteLine("Distância inválida, tente novamente");
                break;
            }
            double valorCarro = carroUber.CalcularCorrida(distanciaCarro);
            Console.WriteLine($"Valor da corrida de carro: R${valorCarro:F2}");
            break;
        case "2":
            Console.WriteLine("Digite a distância da corrida em km");
            double distanciaMoto = double.Parse(Console.ReadLine()!);
            if (distanciaMoto <= 0)
            {
                Console.WriteLine("Distância inválida, tente novamente");
                break;
            }
            double valorMoto = motoUber.CalcularCorrida(distanciaMoto);
            Console.WriteLine($"Valor da corrida de moto: R${valorMoto:F2}");
            break;
        case "3":
            carroUber.MostrarHistorico();
            break;
        case "4":
            motoUber.MostrarHistorico();
            break;
        case "5":
            carroUber.AtualizarLocalizacao();
            break;
        case "6":
            motoUber.AtualizarLocalizacao();
            break;
        case "7":
            continuar = false;
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }
}

// -----------------------------------------------------
//    Exercício 11
// -----------------------------------------------------

continuar = true;
Sistema sistema = new Sistema();

while (continuar)
{
    Console.WriteLine("Digite o número do plugin que deseja usar");
    Console.WriteLine("1 - Plugin de áudio");
    Console.WriteLine("2 - Plugin de vídeo");
    Console.WriteLine("3 - Plugin de segurança");
    Console.WriteLine("4 - Ligar todos os plugins");
    Console.WriteLine("5 - Encerrar todos os plugins");
    Console.WriteLine("6 - Sair");
    string opcaoPlugin = Console.ReadLine()!;

    switch (opcaoPlugin)
    {
        case "1":
            Console.WriteLine("Plugin de áudio selecionado");
            Console.WriteLine("Digite uma das opções desejadas abaixo");
            Console.WriteLine("1 - Executar plugin de áudio");
            Console.WriteLine("2 - Encerrar plugin de áudio");
            string opcaoAudio = Console.ReadLine()!;

            switch (opcaoAudio)
            {
                case "1":
                    sistema.ExecutarPlugin(opcaoPlugin);
                    break;
                case "2":
                    sistema.EncerrarPlugin(opcaoPlugin);
                    break;
                default:
                    Console.WriteLine("Opção de plugin inválida, programa encerrado");
                    break;
            }
            break;
        case "2":
            Console.WriteLine("Plugin de vídeo selecionado");
            Console.WriteLine("Digite uma das opções desejadas abaixo");
            Console.WriteLine("1 - Executar plugin de vídeo");
            Console.WriteLine("2 - Encerrar plugin de vídeo");
            string opcaoVideo = Console.ReadLine()!;

            switch (opcaoVideo)
            {
                case "1":
                    sistema.ExecutarPlugin(opcaoPlugin);
                    break;
                case "2":
                    sistema.EncerrarPlugin(opcaoPlugin);
                    break;
                default:
                    Console.WriteLine("Opção de plugin inválida, programa encerrado");
                    break;
            }
            break;
        case "3":
            Console.WriteLine("Plugin de segurança selecionado");
            Console.WriteLine("Digite uma das opções desejadas abaixo");
            Console.WriteLine("1 - Executar plugin de segurança");
            Console.WriteLine("2 - Encerrar plugin de segurança");
            string opcaoSeguranca = Console.ReadLine()!;

            switch (opcaoSeguranca)
            {
                case "1":
                    sistema.ExecutarPlugin(opcaoPlugin);
                    break;
                case "2":
                    sistema.EncerrarPlugin(opcaoPlugin);
                    break;
                default:
                    Console.WriteLine("Opção de plugin inválida, programa encerrado");
                    break;
            }
            break;
        case "4":
            sistema.ExecutarTudo();
            break;
        case "5":
            sistema.EncerrarTudo();
            break;
        case "6":
            continuar = false;
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Opção de plugin inválida, programa encerrado");
            break;
    }
}
using testec_.Models;

bool Continuar()
{
    while (true)
    {
        Console.Write("Deseja continuar utilizando nosso sistema? [S/N] ");
        string? continuar = Console.ReadLine();
        if (continuar == null)
        {
            Console.WriteLine("Opção inválida, tente novamente!");
        }
        else
        {
            if (continuar.ToUpper() == "S")
            {
                return true;
            }
            else if (continuar.ToUpper() == "N")
            {
                return false;
            }
            Console.WriteLine("Opção inválida, tente novamente!");
        }
    }
}

ContaCorrente BuscarConta(int numero, List<ContaCorrente> contas)
{
    var contaEncontrada = contas.FirstOrDefault(conta => conta.Numero == numero);
    if (contaEncontrada != null)
    {
        return contaEncontrada;
    }
    else
    {
        throw new Exception("Conta não encontrada");
    }
}

List<Usuario> usuarios = new List<Usuario>();
List<ContaCorrente> contas = new List<ContaCorrente>();

while (true)
{
    Console.WriteLine("--------------------------------------------------------------------------------------");
    Console.WriteLine("1- Criar novo usuário\n2- Criar Conta Corrente\n3-Conferir Saldo\n4-Depositar\n5-Sacar\n6-Mostrar histórico de transações\n7-Sair");
    Console.WriteLine("--------------------------------------------------------------------------------------");
    Console.Write("Bem vindo ao Banco, selecione uma das seguintes opções: ");
    var escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1":
            Console.Write("Digite o seu nome: ");
            var nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            var sobrenome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (nome != null && sobrenome != null && idade != 0)
            {
                Usuario usuario = new Usuario(nome, sobrenome, idade);
                usuarios.Add(usuario);
                Console.WriteLine($"Usuário criado com sucesso!");
                Console.WriteLine($"Informações do novo usuário:\nID: {usuario.Id}\nNome: {usuario.NomeCompleto}\nIdade: {usuario.Idade}");
            }
            break;
        case "2":
            Console.Write("Digite o ID do usuário que será titular da conta: ");
            int idUsuario = Convert.ToInt32(Console.ReadLine());

            var usuarioEncontrado = usuarios.FirstOrDefault(usuario => usuario.Id == idUsuario);

            if (usuarioEncontrado != null)
            {
                ContaCorrente conta = new ContaCorrente(usuarioEncontrado);
                contas.Add(conta);
                Console.WriteLine("Conta criada com sucesso!");
                conta.MostrarInformações();
            }
            else
            {
                Console.WriteLine("Usuário não encontrado!");
            }
            break;
        case "3":
            Console.Write("Digite o número da conta que quer acessar o saldo: ");
            int numContaSaldo = Convert.ToInt32(Console.ReadLine());

            var contaEncontradaS = BuscarConta(numContaSaldo, contas);

            Console.WriteLine(contaEncontradaS.Saldo);
            break;
        case "4":
            Console.Write("Digite o número da conta que deseja depositar: ");
            int numContaDeposito = Convert.ToInt32(Console.ReadLine());
            var contaEncontradaDeposito = BuscarConta(numContaDeposito, contas);

            Console.Write("Digite o valor que deseja depositar: ");
            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

            contaEncontradaDeposito.Depositar(valorDeposito);
            break;
        case "5":
            Console.Write("Digite o número da conta que deseja sacar: ");
            int numContaSaque = Convert.ToInt32(Console.ReadLine());
            var contaEncontradaSaque = BuscarConta(numContaSaque, contas);

            Console.Write("Digite o valor que deseja depositar: ");
            decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

            contaEncontradaSaque.Sacar(valorSaque);
            break;
        case "6":
            Console.Write("Digite o número da conta que deseja acessar o histórico de transações: ");
            int numContaHistorico = Convert.ToInt32(Console.ReadLine());

            var contaEncontradaH = BuscarConta(numContaHistorico, contas);

            contaEncontradaH.Historico.MostrarTransacoes();
            break;
        case "7":
            Console.WriteLine("Saindo...");
            return;
        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }
    if (!Continuar())
    {
        Console.WriteLine("Saindo...");
        return;
    }
}

using DesafioFundamentos.models;
Console.OutputEncoding = System.Text.Encoding.UTF8;
decimal PrecoInicial = 0;
decimal PrecoHora = 0;

Console.WriteLine("Bem-vindo ao Silsaw Estacionamento!\nDigite o preço inicial: ");
PrecoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor cobrado por hora: ");
PrecoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento Es =  new Estacionamento(PrecoInicial, PrecoHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu){
    Console.Clear();
    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("1 - Cadastrar um novo carro");
    Console.WriteLine("2 - Remover um veículo");
    Console.WriteLine("3 - Listar Carros");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine()){
        case "1":
            Es.adicionarVeiculo();
            break;
        case "2":
            Es.RemoverVeiculo();
            break;
        case "3":
            Es.ListarCarro();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();    
    
}
Console.WriteLine("O programa se encerrou");
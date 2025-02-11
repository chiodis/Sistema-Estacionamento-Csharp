using ProjetoEstacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoinicial = 0;
decimal precoporhora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial:");
precoinicial = decimal.Parse(Console.ReadLine());

Console.WriteLine("agora digite o preço por hora:");
precoporhora = decimal.Parse(Console.ReadLine());

//instacia a classse estacionamento, com o os valores obtidos anteriormente 
Estacionamento es = new Estacionamento(precoinicial, precoporhora);

string opcao = string.Empty;
bool exibirmenu = true;

//realiza o loop do menu    
while (exibirmenu)
{
    Console.Clear();
    Console.WriteLine("digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.adicionarveiculo();
            break;

        case "2":
            es.removerveiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirmenu = false;
            break;

        default:
            Console.WriteLine("opção invalida");
            break;
    }
    Console.WriteLine("pressione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("o programa se encerrou");
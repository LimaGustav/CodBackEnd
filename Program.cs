// See https://aka.ms/new-console-template for more information

using CodificacaoAT.Classes;

string? opcao = "";
PessoaJuridica metodosPJ =new PessoaJuridica();
do
{
    Console.Clear(); // Limpar o console

    //Exibir o menu
    Console.WriteLine(@"
    
    1 - Cadastrar PJ
    2 - Listar PJ
    0 - Sair
    ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": // Cadastra PJ
            PessoaJuridica pj = new PessoaJuridica();

            Console.WriteLine("Informe o nome da PJ: ");
            pj.Nome = Console.ReadLine();

            Console.WriteLine("Informe o rendimento da PJ: ");
            pj.Rendimento = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o CNPJ da PJ: ");
            pj.CNPJ = Console.ReadLine();

            metodosPJ.Inserir(pj);

            Console.WriteLine("Pessoa Juridica cadastrada com sucesso");
            Console.ReadLine();
            break;

        case "2": // Listar PJ
            // Pedir o nome da PJ
            Console.WriteLine("Digite o nome da PJ: ");

            // Salvar o nome da PJ que o usuário digitou
            string? nomePJ = Console.ReadLine();

            // Usa o método ler para obter os dados do arquivo
            PessoaJuridica pjLida = metodosPJ.Ler(nomePJ!);

            Console.WriteLine($@"

                Nome: {pjLida.Nome}
                Rendimento: R${pjLida.Rendimento},00
                Cpnj: {pjLida.CNPJ}
            ");

            // Espera que o usuário digite algum caracter para prosseguir
            Console.Read();
            break;

        default:
            break;
    }
    
} while (opcao != "0");
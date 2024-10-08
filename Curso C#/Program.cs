using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Curso_C_;

namespace SistemaMaquinasConstrucao;

internal class Program
{
    private static List<Cliente> clientes = new List<Cliente>();

    private static LojaMaquinas lojaMaquinas = new LojaMaquinas();

    private static void Main(string[] args)
    {
        CarregarDados();
        int opcao = 0;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 SISTEMA DE LOCAÇÃO E MANUTENÇÃO DE MÁQUINAS             ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Data e Hora: {DateTime.Now}");
            Console.WriteLine();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 1. Gerenciar Máquinas                                          ║");
            Console.WriteLine("║ 2. Gerenciar Clientes                                          ║");
            Console.WriteLine("║ 3. Serviços de Manutenção                                      ║");
            Console.WriteLine("║ 4. Vender Máquina                                              ║");
            Console.WriteLine("║ 0. Sair                                                        ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");

            Console.ResetColor();
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    MenuMaquinas();
                    break;
                case 2:
                    MenuClientes();
                    break;
                case 3:
                    MenuManutencao();
                    break;
                case 4:
                    VenderMaquina();
                    break;
                case 0:
                    SalvarMaquinas();
                    Console.WriteLine("\nSaindo do programa...");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    break;
            }
        }
        while (opcao != 0);
    }

    private static void MenuMaquinas()
    {
        int opcao = 0;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   GERENCIAMENTO DE MÁQUINAS                         ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Data e Hora: {DateTime.Now}");
            Console.WriteLine();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 1. Adicionar Máquina                                                ║");
            Console.WriteLine("║ 2. Listar Máquinas                                                  ║");
            Console.WriteLine("║ 3. Alugar Máquina                                                   ║");
            Console.WriteLine("║ 4. Devolver Máquina                                                 ║");
            Console.WriteLine("║ 0. Voltar                                                           ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            // Validação da entrada de opção
           
            do
            {
                Console.Write("Escolha uma opção: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out opcao) || opcao < 0 || opcao > 4)
                {
                    Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção entre 0 e 4.");
                }

            } while (opcao < 0 || opcao > 4);

            // Lógica baseada na escolha do usuário
            switch (opcao)
            {
                case 1:
                    // Chamar a função para adicionar máquina
                    AdicionarMaquina();
                    break;
                case 2:
                    // Chamar a função para adicionar máquina
                    lojaMaquinas.ListarMaquinas();
                    break;
                case 3:
                    // Chamar a função para alugar máquina
                    AlugarMaquina();
                    break;
                case 4:
                    // Chamar a função para devolver máquina
                    DevolverMaquina();
                    break;
                case 0:
                    Console.WriteLine("\nVoltando ao menu principal...");
                    break;
            }


            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    AdicionarMaquina();
                    break;
                case 2:
                    lojaMaquinas.ListarMaquinas();
                    break;
                case 3:
                    AlugarMaquina();
                    break;
                case 4:
                    DevolverMaquina();
                    break;
                case 0:
                    Console.WriteLine("\nVoltando ao menu principal...");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        while (opcao != 0);
    }

    private static void MenuClientes()
    {
        int opcao = 0;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    GERENCIAMENTO DE CLIENTES                        ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Data e Hora: {DateTime.Now}");
            Console.WriteLine();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 1. Adicionar Cliente                                                ║");
            Console.WriteLine("║ 2. Listar Clientes                                                  ║");
            Console.WriteLine("║ 3. Remover Cliente                                                  ║");
            Console.WriteLine("║ 0. Voltar                                                           ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            // Validação da entrada de opção
           
            do
            {
                Console.Write("Escolha uma opção: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out opcao) || opcao < 0 || opcao > 3)
                {
                    Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção entre 0 e 3.");
                }

            } while (opcao < 0 || opcao > 3);

            // Lógica baseada na escolha do usuário
            switch (opcao)
            {
                case 1:
                    // Chamar a função para adicionar cliente
                    AdicionarCliente();
                    break;
                case 2:
                    // Chamar a função para listar clientes
                    ListarClientes();
                    break;
                case 3:
                    // Chamar a função para remover cliente
                    RemoverCliente();
                    break;
                case 0:
                    Console.WriteLine("\nVoltando ao menu principal...");
                    break;
            }

            switch (opcao)
            {
                case 1:
                    AdicionarCliente();
                    break;
                case 2:
                    ListarClientes();
                    break;
                case 3:
                    RemoverCliente();
                    break;
                case 0:
                    Console.WriteLine("\nVoltando ao menu principal...");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        while (opcao != 0);
    }

    private static void MenuManutencao()
    {
        int opcao = 0;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                SERVIÇOS DE MANUTENÇÃO                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Data e Hora: {DateTime.Now}");
            Console.WriteLine();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 1. Solicitar Manutenção                                             ║");
            Console.WriteLine("║ 2. Listar Manutenções                                               ║");
            Console.WriteLine("║ 0. Voltar                                                           ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            // Validação da entrada de opção
          
            do
            {
                Console.Write("Escolha uma opção: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out opcao) || opcao < 0 || opcao > 2)
                {
                    Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção entre 0 e 2.");
                }

            } while (opcao < 0 || opcao > 2);

            // Executa a lógica correspondente à opção escolhida
            switch (opcao)
            {
                case 1:
                    // Lógica para solicitar manutenção
                    break;
                case 2:
                    // Lógica para listar manutenções
                    break;
                case 0:
                    Console.WriteLine("\nVoltando ao menu principal...");
                    break;
            }

            switch (opcao)
            {
                case 1:
                    SolicitarManutencao();
                    break;
                case 2:
                    ListarManutencoes();
                    break;
                case 0:
                    Console.WriteLine("\nVoltando ao menu principal...");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        while (opcao != 0);
    }

    private static void AdicionarCliente()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                   ADICIONAR NOVO CLIENTE                            ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Data e Hora: {DateTime.Now}");

        // Validação do nome do cliente
        string nome;
        do
        {
            Console.Write("Digite o nome do cliente: ");
            nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome inválido. Por favor, insira um nome válido.");
            }
        } while (string.IsNullOrWhiteSpace(nome));

        // Validação do CPF do cliente
        string cpf;
        do
        {
            Console.Write("Digite o CPF do cliente (somente números): ");
            cpf = Console.ReadLine();

            // Checagem se o CPF é válido (11 dígitos numéricos)
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                Console.WriteLine("CPF inválido. Por favor, insira um CPF válido com 11 dígitos.");
                continue;
            }

            // Verificação se o CPF já está cadastrado
            if (clientes.Any((Cliente u) => u.Cpf == cpf))
            {
                Console.WriteLine("\nCliente com este CPF já existe.");
                return;
            }

        } while (cpf.Length != 11 || !cpf.All(char.IsDigit));

        // Criar cliente e adicionar à lista
        Cliente cliente = new Cliente(nome, cpf);
        clientes.Add(cliente);

        Console.WriteLine("\nCliente adicionado com sucesso!");
        SalvarClientes();

    }

    private static void AdicionarMaquina()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    ADICIONAR NOVA MÁQUINA                           ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Data e Hora: {DateTime.Now}");

        // Validação do nome da máquina
        string nome;
        do
        {
            Console.Write("Digite o nome da máquina: ");
            nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome inválido. Por favor, insira um nome válido.");
            }
        } while (string.IsNullOrWhiteSpace(nome));

        // Validação da marca da máquina
        string marca;
        do
        {
            Console.Write("Digite a marca da máquina: ");
            marca = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(marca))
            {
                Console.WriteLine("Marca inválida. Por favor, insira uma marca válida.");
            }
        } while (string.IsNullOrWhiteSpace(marca));

        // Validação do ano de fabricação
        int ano;
        while (true)
        {
            Console.Write("Digite o ano de fabricação: ");
            if (int.TryParse(Console.ReadLine(), out ano) && ano > 1900 && ano <= DateTime.Now.Year)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ano inválido. Insira um ano de fabricação entre 1900 e o ano atual.");
            }
        }

        // Validação do tipo da máquina (opcional)
        Console.Write("Digite o tipo da máquina (opcional): ");
        string tipo = Console.ReadLine(); // Tipo é opcional, então pode estar em branco

        // Criação da máquina
        Maquina maquina = new Maquina(nome, marca, ano, tipo);

        // Adicionando a máquina à loja
        lojaMaquinas.AdicionarMaquina(maquina);
        Console.WriteLine("\nMáquina adicionada com sucesso!");

    }

    private static void AlugarMaquina()
    {
        ListarClientes();
        Console.Write("\nDigite o número do cliente que irá alugar a máquina: ");
        int clienteIndice = int.Parse(Console.ReadLine()) - 1;
        if (clienteIndice >= 0 && clienteIndice < clientes.Count)
        {
            Cliente cliente = clientes[clienteIndice];
            Console.Write("Digite o nome da máquina: ");
            string nomeMaquina = Console.ReadLine();
            Maquina maquina = lojaMaquinas.BuscarMaquinaPorNome(nomeMaquina);
            if (maquina != null)
            {
                cliente.AlugarMaquina(maquina, lojaMaquinas);
                SalvarLocacoes();
            }
            else
            {
                Console.WriteLine("\nMáquina não encontrada.");
            }
        }
        else
        {
            Console.WriteLine("\nNúmero de cliente inválido.");
        }
    }

    private static void DevolverMaquina()
    {
        ListarClientes();
        Console.Write("\nDigite o número do cliente que irá devolver a máquina: ");
        int clienteIndice = int.Parse(Console.ReadLine()) - 1;
        if (clienteIndice >= 0 && clienteIndice < clientes.Count)
        {
            Cliente cliente = clientes[clienteIndice];
            Console.Write("Digite o nome da máquina: ");
            string nomeMaquina = Console.ReadLine();
            Maquina maquina = lojaMaquinas.BuscarMaquinaPorNome(nomeMaquina);
            if (maquina != null)
            {
                cliente.DevolverMaquina(maquina, lojaMaquinas);
                SalvarLocacoes();
            }
            else
            {
                Console.WriteLine("\nMáquina não encontrada.");
            }
        }
        else
        {
            Console.WriteLine("\nNúmero de cliente inválido.");
        }
    }



    private static void VenderMaquina()
    {
        ListarClientes();
        Console.Write("\nDigite o número do cliente que está comprando a máquina: ");
        int clienteIndice = int.Parse(Console.ReadLine()) - 1;
        if (clienteIndice >= 0 && clienteIndice < clientes.Count)
        {
            Cliente cliente = clientes[clienteIndice];
            Console.Write("Digite o nome da máquina a ser vendida: ");
            string nomeMaquina = Console.ReadLine();
            Maquina maquina = lojaMaquinas.BuscarMaquinaPorNome(nomeMaquina);
            if (maquina != null)
            {
                lojaMaquinas.RemoverMaquina(maquina);
                cliente.AdicionarMaquina(maquina);
                Console.WriteLine("\nMáquina vendida com sucesso!");
                SalvarMaquinas();
                SalvarClientes();
            }
            else
            {
                Console.WriteLine("\nMáquina não encontrada.");
            }
        }
        else
        {
            Console.WriteLine("\nNúmero de cliente inválido.");
        }
    }

    private static void SolicitarManutencao()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                     SOLICITAR MANUTENÇÃO                            ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Data e Hora: {DateTime.Now}");
        Console.WriteLine("Solicitação de manutenção registrada.");
    }

    private static void ListarManutencoes()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                     LISTAR MANUTENÇÕES                              ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Data e Hora: {DateTime.Now}");
        Console.WriteLine("Manutenções listadas.");
    }

    private static void ListarClientes()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                        LISTA DE CLIENTES                            ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Data e Hora: {DateTime.Now}");
        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
            return;
        }
        for (int i = 0; i < clientes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {clientes[i].Nome} - CPF: {clientes[i].Cpf}");
        }
        Console.ResetColor();
    }

    private static void RemoverCliente()
    {
        ListarClientes();
        Console.Write("Digite o número do cliente que deseja remover: ");
        int clienteIndice = int.Parse(Console.ReadLine()) - 1;
        if (clienteIndice >= 0 && clienteIndice < clientes.Count)
        {
            clientes.RemoveAt(clienteIndice);
            Console.WriteLine("Cliente removido com sucesso!");
            SalvarClientes();
        }
        else
        {
            Console.WriteLine("Número de cliente inválido.");
        }
    }

    private static void SalvarClientes()
    {
        string json = JsonSerializer.Serialize(clientes, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText("clientes.json", json);
    }

    private static void SalvarMaquinas()
    {
        string json = JsonSerializer.Serialize(lojaMaquinas.ObterMaquinas(), new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText("maquinas.json", json);
    }

    private static void SalvarLocacoes()
    {
        SalvarClientes();
        SalvarMaquinas();
    }

    private static void CarregarDados()
    {
        if (File.Exists("clientes.json"))
        {
            string jsonClientes = File.ReadAllText("clientes.json");
            clientes = JsonSerializer.Deserialize<List<Cliente>>(jsonClientes);
        }
        if (!File.Exists("maquinas.json"))
        {
            return;
        }
        string jsonMaquinas = File.ReadAllText("maquinas.json");
        List<Maquina> maquinas = JsonSerializer.Deserialize<List<Maquina>>(jsonMaquinas);
        foreach (Maquina maquina in maquinas)
        {
            lojaMaquinas.AdicionarMaquina(maquina);
        }
    }



}

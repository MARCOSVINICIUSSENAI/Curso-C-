
using Curso_C_;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml;
using static Curso_C_.Paradigmas._3_Herança;
using static Curso_C_.Paradigmas._4_Agregaçao;
using static Curso_C_.Paradigmas._5_Associacao;
using static Curso_C_.Paradigmas._6_Composicao;
using static Curso_C_.Paradigmas._7_Multiplicidade;

/*namespace BibliotecaVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0; 
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quilometragem do veículo: ");
            int quilometragem = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }
}*/

/* Instância de Cachorro
Cachorro cachorro = new Cachorro("Rex");
cachorro.ExibirInformacoes();
cachorro.FazerSom();
cachorro.ExplicarHeranca();

 Instância de Gato
Gato gato = new Gato("Mimi");
gato.ExibirInformacoes();
gato.FazerSom();
gato.ExplicarHeranca();*/


/*// Criando um objeto Endereco que pode existir independentemente
Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();

*/


/*
// Criando um objeto Departamento
Departamento departamento = new Departamento("Recursos Humanos");

// Criando um objeto Funcionario que está associado a um Departamento
Funcionario funcionarioComDepartamento = new Funcionario("Ana", departamento);

// Criando um objeto Funcionario sem associação a nenhum Departamento
Funcionario funcionarioSemDepartamento = new Funcionario("Carlos");

// Exibir as informações dos funcionários
funcionarioComDepartamento.ExibirInformacoes();
funcionarioSemDepartamento.ExibirInformacoes();

// Explicando o conceito de associação
funcionarioComDepartamento.ExplicarAssociacao();
*/

/*
// Criando um objeto Carro, que inclui a criação de um Motor
Carro carro = new Carro("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();*/


/*// Criando funcionários
FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();*/


namespace SistemaMaquinasConstrucao
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        
        static LojaMaquinas lojaMaquinas = new LojaMaquinas();

        static void Main(string[] args)
        {
            CarregarDados();  // Carregar dados ao iniciar o programa

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=== SISTEMA DE LOCAÇÃO E MANUTENÇÃO DE MÁQUINAS ===");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Gerenciar Máquinas");
                Console.WriteLine("2. Gerenciar Clientes");
                Console.WriteLine("3. Serviços de Manutenção");
                Console.WriteLine("4. Vender Máquina");
                Console.WriteLine("0. Sair");

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
                        SalvarMaquinas();  // Salvar dados antes de sair
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuMaquinas()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=========== GERENCIAMENTO DE MÁQUINAS =========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Máquina");
                Console.WriteLine("2. Listar Máquinas");
                Console.WriteLine("3. Alugar Máquina");
                Console.WriteLine("4. Devolver Máquina");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
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
            } while (opcao != 0);
        }

        static void MenuClientes()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("============ GERENCIAMENTO DE CLIENTES ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Remover Cliente");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

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
            } while (opcao != 0);
        }

        static void MenuManutencao()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("============ SERVIÇOS DE MANUTENÇÃO ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Solicitar Manutenção");
                Console.WriteLine("2. Listar Manutenções");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

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
            } while (opcao != 0);
        }

        static void AdicionarCliente()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO CLIENTE   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();

            // Verificar se o CPF já existe
            if (clientes.Any(u => u.Cpf == cpf))
            {
                Console.WriteLine("\nCliente com este CPF já existe.");
                return;
            }

            Cliente cliente = new Cliente(nome, cpf);
            clientes.Add(cliente);
            Console.WriteLine("\nCliente adicionado com sucesso!");

            // Atualizar o arquivo JSON
            SalvarClientes();
        }

        static void AdicionarMaquina()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   ADICIONAR NOVA MÁQUINA   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome da máquina: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a marca da máquina: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o ano de fabricação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o tipo da máquina (opcional): ");
            string tipo = Console.ReadLine();

            Maquina maquina = new Maquina(nome, marca, ano, tipo);
            lojaMaquinas.AdicionarMaquina(maquina);
            Console.WriteLine("\nMáquina adicionada com sucesso!");
        }



        static void AlugarMaquina()
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

        static void DevolverMaquina()
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

        static void VenderMaquina()
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

        

        static void SolicitarManutencao()
        {
            Console.WriteLine("Solicitação de manutenção registrada.");
        }

        static void ListarManutencoes()
        {
            Console.WriteLine("Manutenções listadas.");
        }

        static void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== LISTA DE CLIENTES ==========");
            Console.WriteLine("==============================================");

            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }

            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clientes[i].Nome} - CPF: {clientes[i].Cpf}");
            }
        }

        static void RemoverCliente()
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

        // Funções para salvar e carregar dados em arquivos JSON usando System.Text.Json
        static void SalvarClientes()
        {
            string json = JsonSerializer.Serialize(clientes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("clientes.json", json);
        }

        static void SalvarMaquinas()
        {
            string json = JsonSerializer.Serialize(lojaMaquinas.ObterMaquinas(), new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("maquinas.json", json);
        }

        static void SalvarLocacoes()
        {
            SalvarClientes();
            SalvarMaquinas();
        }

        static void CarregarDados()
        {
            if (File.Exists("clientes.json"))
            {
                string jsonClientes = File.ReadAllText("clientes.json");
                clientes = JsonSerializer.Deserialize<List<Cliente>>(jsonClientes);
            }

            if (File.Exists("maquinas.json"))
            {
                string jsonMaquinas = File.ReadAllText("maquinas.json");
                var maquinas = JsonSerializer.Deserialize<List<Maquina>>(jsonMaquinas);
                foreach (var maquina in maquinas)
                {
                    lojaMaquinas.AdicionarMaquina(maquina);
                }
            }
        }
    }

    // Outras classes para representar as entidades do sistema como Cliente, Maquina, etc.
}

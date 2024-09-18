using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    // Classe Cliente
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<Maquina> MaquinasAlugadas { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            MaquinasAlugadas = new List<Maquina>();
        }

        public void AlugarMaquina(Maquina maquina, LojaMaquinas loja)
        {
            if (loja.RemoverMaquina(maquina))
            {
                MaquinasAlugadas.Add(maquina);
                Console.WriteLine($"Máquina {maquina.Nome} alugada com sucesso para {Nome}.");
            }
            else
            {
                Console.WriteLine("Falha ao alugar máquina. Máquina pode não estar disponível.");
            }
        }

        public void DevolverMaquina(Maquina maquina, LojaMaquinas loja)
        {
            if (MaquinasAlugadas.Contains(maquina))
            {
                MaquinasAlugadas.Remove(maquina);
                loja.AdicionarMaquina(maquina);
                Console.WriteLine($"Máquina {maquina.Nome} devolvida com sucesso.");
            }
            else
            {
                Console.WriteLine("Máquina não encontrada nas máquinas alugadas.");
            }
        }

        public void AdicionarMaquina(Maquina maquina)
        {
            MaquinasAlugadas.Add(maquina);
        }

        public void RemoverMaquina(Maquina maquina)
        {
            MaquinasAlugadas.Remove(maquina);
        }
    }


    // Classe Maquina
    class Maquina
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int AnoFabricacao { get; set; }
        public string Tipo { get; set; }
        public bool EmUso { get; set; }

        public Maquina(string nome, string marca, int anoFabricacao, string tipo = null)
        {
            Nome = nome;
            Marca = marca;
            AnoFabricacao = anoFabricacao;
            Tipo = tipo;
            EmUso = false;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}, Marca: {Marca}, Ano de Fabricação: {AnoFabricacao}, Tipo: {Tipo}");
        }
    }


    // Classe LojaMaquinas
    class LojaMaquinas
    {
        private List<Maquina> maquinas = new List<Maquina>();

        public void AdicionarMaquina(Maquina maquina)
        {
            maquinas.Add(maquina);
        }

        public bool RemoverMaquina(Maquina maquina)
        {
            if (maquinas.Contains(maquina))
            {
                maquinas.Remove(maquina);
                return true;
            }
            return false;
        }

        public Maquina BuscarMaquinaPorNome(string nome)
        {
            return maquinas.FirstOrDefault(m => m.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public List<Maquina> ObterMaquinas()
        {
            return maquinas;
        }

        // Novo método para listar todas as máquinas
        public void ListarMaquinas()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                     LISTA DE MÁQUINAS                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            if (maquinas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║                       NENHUMA MÁQUINA DISPONÍVEL                    ║");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();
            }
            else
            {
                foreach (var maquina in maquinas)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
                    Console.ForegroundColor = ConsoleColor.White;
                    maquina.ExibirDetalhes(); // Supondo que ExibirDetalhes já esteja formatado como desejado
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
                    Console.ResetColor();
                }
            }

        }

     }
    }

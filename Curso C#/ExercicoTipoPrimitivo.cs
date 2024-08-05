using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class ExercicoTipoPrimitivo
    {
        //Modifique o método LerArmazenar para armazenar o sobrenome do usuário e
        //exibi-lo junto com o nome:

        public static void Exercicio01()
        {
            string? nome;
            string? sobrenome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} {sobrenome}");
        }



        //Peça ao usuário para inserir a idade e exiba o nome e a idade:

        public static void Exercicio02()
        {
            string? nome;
            int idade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O nome e: {nome} {idade}");
        }

        //Peça ao usuário para inserir a cidade e exiba o nome e a cidade:

        public static void Exercicio03()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} {cidade}");
        }


        //Armazene o nome do usuário em maiúsculas e exiba-o:

        public static void Exercicio04()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a sua cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} {cidade}");
        }

        //Armazene o nome do usuário em minúsculas e exiba-o:

        public static void Exercicio05()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine().ToLower();
            Console.WriteLine("Digite a sua cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} {cidade}");
        }


        // Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma única linha:

        public static void Exercicio06()
        {
            string? nome;
            int idade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O nome e: {nome} e a idade e: {idade}");
        }


        // Peça ao usuário para inserir seu nome e cidade de nascimento, depois exiba ambos:

        public static void Exercicio07()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua cidade de nascimento:");
            cidade = Console.ReadLine();


            Console.WriteLine($"O nome é: {nome} sua cidade de nascimento é: {cidade}");
        }

        // Peça ao usuário para inserir seu nome e profissão, depois exiba ambos:

        public static void Exercicio08()
        {
            string? nome;
            string? profissão;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua profissão:");
            profissão = Console.ReadLine();


            Console.WriteLine($"O nome é: {nome} sua profissão é: {profissão}");
        }


        // Peça ao usuário para inserir seu nome e país de origem, depois exiba ambos:

        public static void Exercicio09()
        {
            string? nome;
            string? paisDeOrigem;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu país de origem:");
            paisDeOrigem = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O país de origem é: {paisDeOrigem}.");
        }

        // Peça ao usuário para inserir seu nome e número favorito, depois exiba ambos:

        public static void Exercicio10()
        {
            string? nome;
            string? numeroFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu número favorito:");
            numeroFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O número favorito é: {numeroFavorito}.");
        }


        // Peça ao usuário para inserir seu nome e hobby favorito, depois exiba ambos:

        public static void Exercicio11()
        {
            string? nome;
            string? hobbyFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu hobby favorito:");
            hobbyFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O hobby favorito é: {hobbyFavorito}.");
        }

        // Peça ao usuário para inserir seu nome e cor favorita, depois exiba ambos:

        public static void Exercicio12()
        {
            string? nome;
            string? corFavorita;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a sua cor favorita:");
            corFavorita = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. A cor favorita é: {corFavorita}.");
        }

        // Peça ao usuário para inserir seu nome e filme favorito, depois exiba ambos:

        public static void Exercicio13()
        {
            string? nome;
            string? filmeFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu filme favorito:");
            filmeFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O filme favorito é: {filmeFavorito}.");
        }


        // Peça ao usuário para inserir seu nome e gênero musical favorito, depois exibi ambos:
        public static void Exercicio14()
        {
            string? nome;
            string? generoMusicalFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu gênero musical favorito:");
            generoMusicalFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O gênero musical favorito é: {generoMusicalFavorito}.");
        }


        // Peça ao usuário para inserir seu nome e animal favorito, depois exiba ambos:

        public static void Exercicio15()
        {
            string? nome;
            string? animalFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu animal favorito:");
            animalFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O animal favorito é: {animalFavorito}.");
        }


        // Peça ao usuário para inserir seu nome e esporte favorito, depois exiba ambos:

        public static void Exercicio16()
        {
            string? nome;
            string? esporteFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu esporte favorito:");
            esporteFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O esporte favorito é: {esporteFavorito}.");
        }

        // Peça ao usuário para inserir seu nome e comida favorita, depois exiba ambos:

        public static void Exercicio17()
        {
            string? nome;
            string? comidaFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu esporte favorito:");
            comidaFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O esporte favorito é: {comidaFavorito}.");
        }

        // Peça ao usuário para inserir seu nome e banda favorita, depois exiba ambos:

        public static void Exercicio18()
        {
            string? nome;
            string? bandaFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu esporte favorito:");
            bandaFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O esporte favorito é: {bandaFavorito}.");
        }

        // Peça ao usuário para inserir seu nome e livro favorito, depois exiba ambos:

        public static void Exercicio19()
        {
            string? nome;
            string? livroFavorito;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu esporte favorito:");
            livroFavorito = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O esporte favorito é: {livroFavorito}.");
        }


        // Peça ao usuário para inserir seu nome e um lema de vida, depois exiba ambos:


        public static void Exercicio20()
        {
            string? nome;
            string? lemadevida;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu esporte favorito:");
            lemadevida = Console.ReadLine();

            Console.WriteLine($"O nome é: {nome}. O esporte favorito é: {lemadevida}.");
        }



    }
}

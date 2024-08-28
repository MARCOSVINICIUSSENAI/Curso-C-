using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Curso_C_
{
    /* Declaração de Variáveis com var:
  Exercício: Declare uma variável de cada um dos seguintes tipos usando var e
 atribua a elas valores apropriados.Depois, exiba o tipo da variável usando
 GetType() para confirmar a inferência do tipo.*/

    class Program
    {
        static void Main()
        {
            // Declaração de variáveis usando var
            var inteiro = 100;
            var flutuante = 10.5f;
            var duplo = 20.99;
            var texto = "Exemplo de string";
            var caractere = 'C';
            var booleano = false;
            var decimalPrecisao = 1000.99m;

            // Exibição dos tipos usando GetType()
            Console.WriteLine($"Tipo da variável 'inteiro': {inteiro.GetType()}");
            Console.WriteLine($"Tipo da variável 'flutuante': {flutuante.GetType()}");
            Console.WriteLine($"Tipo da variável 'duplo': {duplo.GetType()}");
            Console.WriteLine($"Tipo da variável 'texto': {texto.GetType()}");
            Console.WriteLine($"Tipo da variável 'caractere': {caractere.GetType()}");
            Console.WriteLine($"Tipo da variável 'booleano': {booleano.GetType()}");
            Console.WriteLine($"Tipo da variável 'decimalPrecisao': {decimalPrecisao.GetType()}");
        }


        /*Utilizando var em Métodos de LINQ:
       Exercício: Crie uma lista de inteiros e use um método LINQ para ordenar a lista
      em ordem crescente.Declare a variável que armazena o resultado usando var.*/
        static void Main()
        {
            // Criação de uma lista de inteiros
            List<int> numeros = new List<int> { 5, 3, 8, 1, 4, 7, 6, 2 };

            // Ordenando a lista em ordem crescente usando LINQ e armazenando o resultado em uma variável var
            var numerosOrdenados = numeros.OrderBy(num => num);

            // Exibindo os números ordenados
            Console.WriteLine("Números ordenados em ordem crescente:");
            foreach (var numero in numerosOrdenados)
            {
                Console.WriteLine(numero);
            }
        }


        /*Declaração de Variáveis com Tipos Complexos:
         Exercício: Declare uma variável var para um tipo complexo, como um
        Dictionary ou uma instância de uma classe personalizada.Mostre como a
        inferência de tipo funciona com tipos mais complexos.*/

        static void Main()
        {
            // Declaração de um Dictionary usando var
            var idadesPorNome = new Dictionary<string, int>
            {
              { "Ana", 30 },
              { "Carlos", 25 },
              { "Beatriz", 28 }
            };

            // Exibindo o tipo da variável usando GetType()
            Console.WriteLine($"Tipo da variável 'idadesPorNome': {idadesPorNome.GetType()}");

            // Iterando e exibindo o conteúdo do Dictionary
            foreach (var item in idadesPorNome)
            {
                Console.WriteLine($"{item.Key} tem {item.Value} anos.");
            }
        }


        /* Trabalhando com Tipos Anônimos:
         Exercício: Crie um tipo anônimo usando var para armazenar informações de
        uma pessoa(nome e idade) e exiba essas informações.*/

        static void Main()
        {
            // Criação de um tipo anônimo usando var
            var pessoa = new
            {
                Nome = "Maria",
                Idade = 35
            };

            // Exibindo as informações do tipo anônimo
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
        }

    }

}
using System;
using static Curso_C_._21_metodo;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;


namespace Curso_C_
{
   /* 1 Crie uma classe chamada Pessoa com as propriedades Nome e Idade.Adicione um construtor
    que inicialize essas propriedades e um método Falar que imprima uma mensagem dizendo
    &quot; Olá, meu nome é[Nome] e eu tenho[Idade] anos.&quot;. Em seguida, crie uma instância da classe
    Pessoa, defina os valores das propriedades e chame o método Falar.*/


    public class Pessoa1
    {
        private string Nome;
        private int Idade;
        
        public Pessoa1(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }




       /*2 Crie uma classe Calculadora com um método Soma que recebe dois parâmetros inteiros e
        retorna a soma deles.Adicione também um método Subtracao que realiza a subtração de dois
        números.Instancie a classe Calculadora, use os métodos para fazer algumas operações e exiba
        os resultados.*/
       public class Calculadora
       {
            public int Soma(int a, int b)
            {
                return a + b;
            }
            public int Subtracao(int a, int b)
            { 
                return a - b;
            }   
       }


    /*3 Crie uma classe Carro com as propriedades Modelo, Ano e Preco.Utilize propriedades
    automáticas para encapsular essas informações. Adicione um método ExibirInfo que exiba os
    detalhes do carro.Instancie a classe Carro, defina valores para as propriedades e chame o
    método ExibirInfo.*/

    /*public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Preco { get; set; }

        public Carro(string modelo, int ano, int preco)
        {
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
        }   
        public void ExibirInformacoes()
        {
            Console.WriteLine($"O modelo do carro e: {Modelo} O ano do carro e: {Ano} O preço do carro e: {Preco}");
        }
    }*/




    /*4 Crie uma classe Matematica com um método estático Fatorial que calcula o fatorial de um
    número inteiro não-negativo.O método deve retornar o resultado.Utilize o método Fatorial
    para calcular o fatorial de alguns números e exiba os resultados.*/





}
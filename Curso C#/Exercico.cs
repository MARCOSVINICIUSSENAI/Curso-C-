﻿using System;
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
    para calcular o fatorial de alguns números e exiba os resultados.

    public class Matematica
    {
        public int num;

        public void Fatorial(int n)
        {
            num = n;
            int Fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                Fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {n} é: {Fatorial}");
        }
    }*/


    /* 5 Crie uma classe Retangulo com propriedades Largura e Altura.Implemente dois construtores:
     um que aceita largura e altura como parâmetros e outro que usa valores padrão(largura e
     altura de 1). Adicione um método CalcularArea que retorna a área do retângulo.Instancie a
     classe Retangulo usando ambos os construtores e exiba a área calculada.

    public class Retangulo
    {
        public int Largura;
        public int Altura;
        public Retangulo (int largura, int altura)
        {
            Largura = largura;
            Altura = altura;

        }
        public int CalcularArea()
        {
            return Altura * Largura;
        }
    }*/


    /*6 Crie uma classe Pessoa com um método de instância AumentarIdade que incrementa a idade
    da pessoa e um método estático CriarPessoa que cria uma nova instância de Pessoa com idade
    inicial de 0. Instancie a classe usando o método estático e chame o método AumentarIdade.

    public class Pessoa225
    {
        public int Idade = 0;
        public int AumentarIdade()
        {
            return Idade++;

        }

        public  int CriarPessoa()
        {
            return Idade = 0;

        }
    }*/
}
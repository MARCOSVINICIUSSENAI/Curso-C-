using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Curso_C_
{
    public static void _11_Array()
    {
        // 1 declaracao e inicializacao de Arrays
        int[] numeros = new int[S]; // Array de inteiros com 5 elementos 
        string[] diaDaSemana = { "Domingo", "segunda feira", "terca feira", "quarta feira" };


        // 2 atribuicao de valores aos elementos do Array
        numeros[0] = 10; //atribui 10 ao primeiro elemento
        numeros[1] = 20; //atribui 20 ao segundo elemento
        numeros[2] = 30; //atribui 30 ao terceiro elemento
        numeros[3] = 40; //atribui 40 ao quarto elemento
        numeros[4] = 50; //atribui 50 ao quinto elemento


        // 3 acesso aos elementos do Array
        Console.WriteLine("acessando elementos do array:");
        Console.WriteLine("primeiro elementos de numeros:{numeros[0]}");
        Console.WriteLine("terceiro elementos de diaDaSemana:{diaDaSemana[2]}");



        //  4 iteracao em array usando 'for'
        Console.WriteLine("\nEstrutura usando 'for':");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"elemento {i} do array numeros: {numeros[i]}");

        }



        // 5 iteracao em array usando 'foreach'
        Console.WriteLine("\nEstrutura usando 'foreach':");
        foreach (string dia in diaDaSemana)
        {
            Console.WriteLine($"Dia da semana: {dia}");
        }



        // 6 array multidimensionais (matrizes)
        int[,] matriz = new int[3, 2]

        {
            {1, 2 },
            {3, 4 },
            {5, 6 },
        };
        Console.WriteLine("\nAcessando elementos de um array multidimensional:");
        Console.WriteLine($"elemento [0, 0] da matriz: {matriz[0, 0]}");
        Console.WriteLine($"elemento [1, 1] da matriz: {matriz[1, 1]}");


        // 7 array jagged irregulares 
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };


        Console.WriteLine("\nAcessando elementos de um array jagged:");
        Console.WriteLine($"elemento [0][1] do jaggedArray: {jaggedArray[0][1]}");
        Console.WriteLine($"elemento [2][3] do jaggedArray: {jaggedArray[2][3]}");

    }
}

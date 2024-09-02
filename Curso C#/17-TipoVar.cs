using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class VarUsageExample
    {
        public void DemonstrateVarUsage()
        {
            // Exemplo 1: Inferência de Tipo
            var integerNumber = 42; // O compilador infere que o tipo é int
            var doubleNumber = 3.14; // O compilador infere que o tipo é double
            var greeting = "Hello, World!"; // O compilador infere que o tipo é string

            Console.WriteLine($"integerNumber: {integerNumber}, Type: {integerNumber.GetType()}");
            Console.WriteLine($"doubleNumber: {doubleNumber}, Type: {doubleNumber.GetType()}");
            Console.WriteLine($"greeting: {greeting}, Type: {greeting.GetType()}");

            // Exemplo 2: Inferência com Tipos Complexos
            var person = new Person { Name = "Alice", Age = 30 }; // O compilador infere o tipo como Person

            Console.WriteLine($"Person Name: {person.Name}, Age: {person.Age}");

            // Exemplo 3: Uso com Coleções
            var numbers = new int[] { 1, 2, 3, 4, 5 }; // O compilador infere o tipo como int[]
            var names = new List<string> { "Alice", "Bob", "Charlie" }; // O compilador infere o tipo como List<string>

            Console.WriteLine("Numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Exemplo 4: Não pode ser usado sem inicialização
            // var uninitializedVar; // Isto resultará em um erro de compilação, pois o tipo não pode ser inferido sem um valor inicial

            // Exemplo 5: Uso com LINQ
            var query = from n in numbers
                        where n % 2 == 0
                        select n;

            Console.WriteLine("Even Numbers:");
            foreach (var evenNumber in query)
            {
                Console.WriteLine(evenNumber);
            }
        }
    }

    // Exemplo de classe usada no exemplo
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}

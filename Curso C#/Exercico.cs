using System.Runtime.Intrinsics.X86;

1.Crie uma consulta LINQ para encontrar todos os nomes das pessoas que têm o nome começando com a letra 'A' e que têm mais de 25 anos.
csharp
Copiar código
var nomesComA = pessoas
    .Where(p => p.Nome.StartsWith("A") && p.Idade > 25)
    .Select(p => p.Nome);

Console.WriteLine("Nomes que começam com 'A' e têm mais de 25 anos:");
foreach (var nome in nomesComA)
{
    Console.WriteLine(nome);
}
2.Adicione uma lista de produtos com propriedades Nome e Preço. Faça uma consulta LINQ para encontrar os produtos cujo preço é superior à média de todos os produtos.
csharp
Copiar código
public class Produto
{
    public string Nome { get; set; }
    public decimal Preço { get; set; }
}

var produtos = new List<Produto>
{
    new Produto { Nome = "Produto A", Preço = 50 },
    new Produto { Nome = "Produto B", Preço = 150 },
    new Produto { Nome = "Produto C", Preço = 200 },
    new Produto { Nome = "Produto D", Preço = 80 }
};

var precoMedio = produtos.Average(p => p.Preço);
var produtosAcimaDaMedia = produtos.Where(p => p.Preço > precoMedio);

Console.WriteLine("Produtos com preço acima da média:");
foreach (var produto in produtosAcimaDaMedia)
{
    Console.WriteLine($"{produto.Nome}, {produto.Preço}");
}
3.Utilizando a lista de pessoas, crie uma consulta LINQ para listar o nome das pessoas em ordem alfabética reversa.
csharp
Copiar código
var pessoasOrdemReversa = pessoas
    .OrderByDescending(p => p.Nome)
    .Select(p => p.Nome);

Console.WriteLine("Nomes das pessoas em ordem alfabética reversa:");
foreach (var nome in pessoasOrdemReversa)
{
    Console.WriteLine(nome);
}
4.Crie uma consulta LINQ para encontrar a pessoa mais jovem de cada cidade.
csharp
Copiar código
var pessoaMaisJovemPorCidade = pessoas
    .GroupBy(p => p.Cidade)
    .Select(grupo => grupo.OrderBy(p => p.Idade).First());

Console.WriteLine("Pessoa mais jovem por cidade:");
foreach (var pessoa in pessoaMaisJovemPorCidade)
{
    Console.WriteLine($"{pessoa.Nome} de {pessoa.Cidade} com {pessoa.Idade} anos");
}
5.Adicione uma lista de livros com propriedades Título, Autor e AnoPublicacao. Faça uma consulta LINQ para encontrar os livros publicados após o ano de 2000 e ordene-os por ano de publicação em ordem crescente.
csharp
Copiar código
public class Livro
{
    public string Título { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
}

var livros = new List<Livro>
{
    new Livro { Título = "Livro A", Autor = "Autor A", AnoPublicacao = 1995 },
    new Livro { Título = "Livro B", Autor = "Autor B", AnoPublicacao = 2005 },
    new Livro { Título = "Livro C", Autor = "Autor C", AnoPublicacao = 2010 },
    new Livro { Título = "Livro D", Autor = "Autor D", AnoPublicacao = 2000 }
};

var livrosDepois2000 = livros
    .Where(l => l.AnoPublicacao > 2000)
    .OrderBy(l => l.AnoPublicacao);

Console.WriteLine("Livros publicados após 2000, ordenados por ano:");
foreach (var livro in livrosDepois2000)
{
    Console.WriteLine($"{livro.Título} por {livro.Autor} ({livro.AnoPublicacao})");
}


Lanche[] menu = new Lanche[]

{
    new Lanche(1, "Cachorro Quente", 4.00),
    new Lanche(2, "X-Salada", 4.50),
    new Lanche(3, "X-Bacon", 5.00),
    new Lanche(4, "Torrada Simples", 2.00),
    new Lanche(5, "Refrigerante", 1.50)
};


string[] entrada = Console.ReadLine().Split(' ');
int codigo = int.Parse(entrada[0]);
int quantidade = int.Parse(entrada[1]);


Lanche lancheSelecionado = null;

foreach (Lanche lanche in menu)
{
    if (lanche.Codigo == codigo)
    {
        lancheSelecionado = lanche;
        break;
    }
}


if (lancheSelecionado != null)
{
    double total = lancheSelecionado.Preco * quantidade;
    Console.WriteLine($"Total: R$ {total:F2}");
}

else

{
    Console.WriteLine("Código de lanche inválido.");
}



List<ListaMercado> compra = new List<ListaMercado>();

float total= 0;
while (true)
{
    Console.WriteLine("Digite o nome do produto:");
    string produto = Console.ReadLine();
    if (produto == "sair")
    {
        break;
    }
    Console.WriteLine("Digite o preço:");
    float preco = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade");
    int quantidade = int.Parse(Console.ReadLine());

    ListaMercado item = new ListaMercado
    {
        Produto = produto,
        Preco = preco,
        Quantidade = quantidade
    };

    compra.Add(item);

    total += preco * quantidade;
}

Console.WriteLine("A sua compra possui:");

foreach (var c in compra)
{
    Console.WriteLine(c.Produto);
}

Console.WriteLine($"Valor total da compra: R${total:F2}");
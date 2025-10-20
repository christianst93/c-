using Modelo;
using Logica;

{
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 1,
        Cliente = "Christian Torres",
        Produto = "PS5 Pro",
        Quantidade = 3,
        ValorUnitario = 3570.12m,
        DataPedido = new DateOnly(2025, 7, 18)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 2,
        Cliente = "Mariana Souza",
        Produto = "Xbox Series X",
        Quantidade = 2,
        ValorUnitario = 3450.00m,
        DataPedido = new DateOnly(2025, 10, 19)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 3,
        Cliente = "Pedro Lima",
        Produto = "Nintendo Switch OLED",
        Quantidade = 1,
        ValorUnitario = 2599.90m,
        DataPedido = new DateOnly(2025, 10, 17)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 4,
        Cliente = "Ana Beatriz",
        Produto = "Controle DualSense",
        Quantidade = 4,
        ValorUnitario = 429.99m,
        DataPedido = new DateOnly(2025, 10, 16)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 5,
        Cliente = "Carlos Mendes",
        Produto = "Fone Pulse 3D",
        Quantidade = 2,
        ValorUnitario = 849.00m,
        DataPedido = new DateOnly(2025, 7, 19)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 6,
        Cliente = "Julia Fernandes",
        Produto = "Teclado Mecânico RGB",
        Quantidade = 1,
        ValorUnitario = 699.99m,
        DataPedido = new DateOnly(2025, 10, 18)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 7,
        Cliente = "Rafael Costa",
        Produto = "Mouse Gamer Logitech G502",
        Quantidade = 2,
        ValorUnitario = 399.90m,
        DataPedido = new DateOnly(2025, 10, 15)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 8,
        Cliente = "Beatriz Oliveira",
        Produto = "Monitor 4K 27''",
        Quantidade = 1,
        ValorUnitario = 2299.00m,
        DataPedido = new DateOnly(2025, 7, 14)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 9,
        Cliente = "Lucas Pereira",
        Produto = "Cadeira Gamer Reclinável",
        Quantidade = 1,
        ValorUnitario = 1599.99m,
        DataPedido = new DateOnly(2025, 10, 12)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 10,
        Cliente = "Amanda Rocha",
        Produto = "Headset HyperX Cloud II",
        Quantidade = 3,
        ValorUnitario = 599.00m,
        DataPedido = new DateOnly(2025, 10, 11)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 11,
        Cliente = "Felipe Almeida",
        Produto = "SSD NVMe 1TB",
        Quantidade = 2,
        ValorUnitario = 489.90m,
        DataPedido = new DateOnly(2025, 10, 10)
    });
    GestorPedidos.AdicionarPedido(new Pedido
    {
        NumeroPedido = 12,
        Cliente = "Larissa Martins",
        Produto = "Placa de Vídeo RTX 4080",
        Quantidade = 1,
        ValorUnitario = 8499.00m,
        DataPedido = new DateOnly(2025, 10, 9)
    });
}

Console.WriteLine($"Total de vendas: R${GestorPedidos.CalcularTotal():F2}");
GestorPedidos.PedidosPorCliente("Christian Torres");
var retorno = GestorPedidos.ValorTotalPorCliente("Rafael Costa");
Console.WriteLine($"Pedido do cliente:{retorno.cliente} | Valor:R${retorno.totalCliente}");
Console.WriteLine("");
GestorPedidos.PedidosMaioresQue(2000m);
Console.WriteLine("");
GestorPedidos.PedidosDoMes(7, 2025);
Console.WriteLine("");
GestorPedidos.CancelarPedido(2);
using Modelo;
namespace Logica;

public class GestorPedidos
{
    public static List<Pedido> pedidos = new List<Pedido>();

    public static void AdicionarPedido(Pedido pedido)
    {        
        pedidos.Add(pedido);
    }

    public static decimal CalcularTotal()
    {
        decimal total = 0m;
        foreach (var item in pedidos)
        {
            total += item.ValorUnitario * item.Quantidade;
        }
        return total;
    }

    public static void PedidosPorCliente(string cliente)
    {
        foreach (var item in pedidos)
        {
            if (item.Cliente.Equals(cliente))
            {
                Console.WriteLine($"O Cliente {item.Cliente} | pediu {item.Produto} | {item.Quantidade} unidade(s).");
            }
        }
    }
    public static (decimal totalCliente, string cliente) ValorTotalPorCliente(string cliente)
    {
        decimal totalCliente = 0m;
        foreach (var item in pedidos)
        {
            if (item.Cliente.Equals(cliente))
            {
                totalCliente += item.ValorUnitario * item.Quantidade;
            }
        }
        return (totalCliente, cliente);
    }

    public static void PedidosMaioresQue(decimal valor)
    {
        decimal ValorPedido = 0m;
        foreach (var item in pedidos)
        {
            ValorPedido = item.Quantidade * item.ValorUnitario;
            if (ValorPedido > valor)
            {
                Console.WriteLine($"Pedido {item.NumeroPedido} | Cliente: {item.Cliente} | esta acima de R$:{valor}");
            }
        }
    }

    public static void PedidosDoMes(int mes, int ano)
    {
        foreach (var item in pedidos)
        {
            if (item.DataPedido.Month == mes && item.DataPedido.Year == ano)
            {
                decimal ValorPedido = item.Quantidade * item.ValorUnitario;
                Console.WriteLine($"O pedido {item.NumeroPedido} | cliente: {item.Cliente} | Valor R$: {ValorPedido} ");
            }
        }
    }
    
    public static void CancelarPedido (int numeroPedido)
    {
        bool encontrado = false;
        for (int i = pedidos.Count - 1; i >= 0; i--)
        {
            if (pedidos[i].NumeroPedido == numeroPedido)
            {
                pedidos.RemoveAt(i);
                Console.WriteLine($"Pedido {numeroPedido} cancelado.");
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("Pedido nao encontrado");
        }
    }
}
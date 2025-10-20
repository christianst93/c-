namespace Modelo;
public record class Pedido
{
    public int NumeroPedido { get; set; } = 000000;
    public  string Cliente { get; set; } = "Desconhecido";
    public string Produto { get; set; } = "??";
    public  int Quantidade { get; set; } = 1;
    public  decimal ValorUnitario { get; set; } = 0.01m;
    public  DateOnly DataPedido { get; set; } = DateOnly.FromDateTime(DateTime.Now);
}
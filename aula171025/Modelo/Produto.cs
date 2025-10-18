namespace Modelo;

public record class Produto {
    public string Descricao {get; set;} = "Desconhecido";   
    public byte Quantidade {get; set;} = 1;
    public decimal Preco {get; set;} = 0.01m;
}
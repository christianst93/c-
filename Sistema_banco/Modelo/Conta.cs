namespace Modelo;
public record class Conta
{
    public string NumeroConta { get; set; } = "00000-0";
    public string Titular { get; set; } = "Desconhecido";
    public decimal Saldo { get; set; } = 0.00m;
    public string TipoConta { get; set; } = "N/I";
}
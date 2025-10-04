//Um Registro -> Substantivo, ex: a pessoa, o pagamento, a transferencia, o veiculo, a motocicleta.
// Estrutura de dados heterogênea
public record class Pessoa
{
    // Propriedades
    public string Nome { get; set; }
    public int idade { get; set; }
    public double peso { get; set; }
    public double altura { get; set; }
}
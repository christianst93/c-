namespace Modelo;

public record class Aluno
{
    public string Nome { get; set; } = "Desconhecido";
    public string Matricula { get; set; } = "000000";
    public float Nota1 { get; set; } = default;
    public float Nota2 { get; set; } = default;
    public float Nota3 { get; set; } = default;
    public float Nota4 { get; set; } = default;
    public float media => (Nota1 + Nota2 + Nota3 + Nota4) / 4;
    public string aprovado => media >= 7 ? "Aprovado" : "Reprovado";    
}
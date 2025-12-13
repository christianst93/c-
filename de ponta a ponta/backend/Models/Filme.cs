using System.Security.Cryptography.X509Certificates;

namespace backend.Models;

public record Filme {
    public string Titulo { get; set; }
    public int Hype { get; set; }
    public string genero { get; set; }
}
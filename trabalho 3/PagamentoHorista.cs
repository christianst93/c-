public record PagamentoHorista
{
    public string horista { get; set; }
    public DateOnly data { get; set; }
    public TimeOnly entrada { get; set; }
    public TimeOnly saida { get; set; }
    public TimeSpan tempo => saida - entrada;
    
    public List<PagamentoHorista> dias { get; set; }
    
}



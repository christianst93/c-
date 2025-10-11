public static class Pagamento
{
    public static (int horasTotais, int horas ,int horasSabado, int horasDomingo, int horasEfetivas, int horasBanco, int horasPagar, int valorHora) DiasTrabalhados(List<PagamentoHorista> dias)
    {
        int horasSabado = 0;
        int horasDomingo = 0;
        int horas = 0;
        int horasTotais;
        int horasBanco = 0;
        int horasPagar;
        int valorHora = 45;
        
        foreach (var d in dias)
        {
            if (d.data.DayOfWeek == DayOfWeek.Saturday)
            {
                horasSabado = (d.saida - d.entrada).Hours;
            }
            else if (d.data.DayOfWeek == DayOfWeek.Sunday)
            {
                horasDomingo = (d.saida - d.entrada).Hours;
            }
            else
            {
                horas = (d.saida - d.entrada).Hours;
            }
        }

        horasTotais = horas + horasSabado + horasDomingo;

        int horasEfetivas = horas + ((int) (horasSabado * 1.5)) + (horasDomingo * 2);

        if (horasEfetivas > 44)
        {
            horasBanco = horasEfetivas - 44;
             horasPagar = 44;
        }
        else
        {
           horasPagar = horasEfetivas;
        }
        return (horasTotais, horas, horasSabado, horasDomingo, horasEfetivas, horasBanco, horasPagar, valorHora);
    }
    
    public static int ValorPagamento(int valorHora ,int horasPagar) 
    {        
        int remuneracaoSemanal = 0;
        return remuneracaoSemanal = valorHora * horasPagar;
    }
}


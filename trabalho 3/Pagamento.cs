public static class Pagamento
{
    public static (int horasTotais, int horas, int horasSabado, int horasDomingo, int horasEfetivas, int horasBanco, int horasPagar, int valorHora, string horista, int remuneracaoSemanal, int diaUtil) DiasTrabalhados(List<PagamentoHorista> dias)
    {
        int horasSabado = 0;
        int horasDomingo = 0;
        int horas = 0;
        int horasTotais;
        int horasBanco = 0;
        int horasPagar;
        int valorHora = 45;
        int cont = 0;
        string horista = "";
        int diaUtil = 0;

        foreach (var d in dias)
        {
            horista = d.horista;
            if (cont == 7)
            {
                break;
            }
            if (d.data.DayOfWeek == DayOfWeek.Saturday)
            {
                horasSabado += (d.saida - d.entrada).Hours;
            }
            else if (d.data.DayOfWeek == DayOfWeek.Sunday)
            {
                horasDomingo += (d.saida - d.entrada).Hours;
            }
            else
            {
                horas += (d.saida - d.entrada).Hours;
            }
            cont++;
        }

        horasTotais = horas + horasSabado + horasDomingo;

        int horasEfetivas = horas + ((int)(horasSabado * 1.5)) + (horasDomingo * 2);


        if (horasEfetivas > 44)
        {
            horasBanco = horasEfetivas - 44;
            horasPagar = 44;
        }
        else
        {
            horasPagar = horasEfetivas;
        }

        int remuneracaoSemanal = valorHora * horasPagar;

        if (remuneracaoSemanal > 0 && remuneracaoSemanal < 500)  
        {
            diaUtil = 1;
        } else if (remuneracaoSemanal < 1000)
        {
            diaUtil = 3;
        } else
        {
            diaUtil = 5;
        }

        return (horasTotais, horas, horasSabado, horasDomingo, horasEfetivas, horasBanco, horasPagar, valorHora, horista, remuneracaoSemanal, diaUtil);
    }
}


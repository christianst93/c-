using Modelo;
using Logica;

List<Conta> novaConta = new List<Conta>()

{
    new Conta {
        NumeroConta = "62737-9",
        Titular = "Christian Torres",
        Saldo = 3200.45m,
        TipoConta = "CC"
        },
    new Conta {
        NumeroConta = "89124-3",
        Titular = "Mariana Silva",
        Saldo = 1520.75m,
        TipoConta = "CP"
    },
    new Conta {
        NumeroConta = "47218-0",
        Titular = "João Pereira",
        Saldo = 875.20m,
        TipoConta = "CS"
    },
    new Conta {
        NumeroConta = "30591-6",
        Titular = "Ana Souza",
        Saldo = 9820.10m,
        TipoConta = "CC"
    },
    new Conta {
        NumeroConta = "15732-4",
        Titular = "Ricardo Lima",
        Saldo = 420.00m,
        TipoConta = "CP"
    },
    new Conta {
        NumeroConta = "69245-8",
        Titular = "Beatriz Santos",
        Saldo = 12450.90m,
        TipoConta = "CC"
    },
    new Conta {
        NumeroConta = "51437-1",
        Titular = "Lucas Almeida",
        Saldo = 655.30m,
        TipoConta = "CP"
    },
    new Conta {
        NumeroConta = "23864-5",
        Titular = "Carla Fernandes",
        Saldo = 7420.00m,
        TipoConta = "CC"
    },
    new Conta {
        NumeroConta = "76329-2",
        Titular = "Felipe Costa",
        Saldo = 315.80m,
        TipoConta = "CP"
    }
};

foreach (var conta in novaConta)
{
    Banco.CriarConta(conta);
}

Console.WriteLine("");
Banco.Depositar("62737-9", 500m);
Console.WriteLine("");
Console.WriteLine(Banco.SaldoConta("62737-9"));
Console.WriteLine("");
Banco.Transferir("69245-8", "62737-9", 500m);
Console.WriteLine("");
Console.WriteLine(Banco.SaldoConta("62737-9"));
Console.WriteLine("");
Banco.ListarContasPorTipo("CC");
Console.WriteLine("");
Console.WriteLine($"Saldo total do Banco: {Banco.SaldoTotalBanco():C}");



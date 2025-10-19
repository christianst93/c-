using Modelo;
namespace Logica;
public class Banco
{
    public static List<Conta> Contas = new List<Conta>();

    public static void CriarConta(Conta novaConta)
    {
        Contas.Add(novaConta);
        Console.WriteLine($"Conta {novaConta.NumeroConta} do cliente {novaConta.Titular} criada.");
    }

    public static decimal Depositar(String numeroConta, decimal valor)
    {
        decimal saldo = 0m;
        foreach (var item in Contas)
        {
            if (item.NumeroConta.Equals(numeroConta))
            {
                item.Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado na conta {numeroConta}.");
                return item.Saldo;
            }
        }
        Console.WriteLine($"Conta {numeroConta} não encontrada.");
        return 0m;
    }

    public static decimal Sacar(String numeroConta, decimal valor)
    {        
        foreach (var item in Contas)
        {
            if (item.NumeroConta.Equals(numeroConta))
            {
                if (item.Saldo >= valor)
                {
                    item.Saldo -= valor;
                } else
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
                return item.Saldo;   
            }
        }
        Console.WriteLine($"Conta {numeroConta} não encontrada.");
        return 0m;
    }
    public static decimal SaldoConta(string conta)
    {
        foreach (var item in Contas)
        {
            if (item.NumeroConta.Equals(conta))
            {
                return item.Saldo;
            }
        }
        Console.WriteLine($"Conta {conta} não encontrada.");
        return 0m;
    }

    public static void Transferir(string contaorigem, string contaDestino, decimal valor)
    {
        bool verifica = false;
        bool origem = false;
        bool destino = false;

        foreach (var item in Contas)
        {
            if (item.NumeroConta.Equals(contaorigem))
            {
                origem = true;
            }
            if (item.NumeroConta.Equals(contaDestino))
            {
                destino = true;
            }
        }

        if (origem == false)
        {
            Console.WriteLine("Conta origem não encontrada.");
            return;
        }
        if (destino == false)
        {
            Console.WriteLine("Conta destino não encontrada.");
            return;
        }
        
        foreach (var item in Contas)
        {
            if (item.NumeroConta.Equals(contaorigem) && item.Saldo >= valor)
            {
                item.Saldo -= valor;
                verifica = true;
            }
            else if (item.NumeroConta.Equals(contaorigem) && item.Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        foreach (var item in Contas)
        {
            if (verifica == true && item.NumeroConta.Equals(contaDestino))
            {
                item.Saldo += valor;
            }
        }
    }

    public static void ListarContasPorTipo(string tipoConta)
    {
        foreach (var item in Contas)
        {
            if (item.TipoConta.Equals(tipoConta))
            {
                Console.WriteLine($"Conta:{item.NumeroConta} | Cliente:{item.Titular} | Tipo:{item.TipoConta}");
            }
        }
    }
    
    public static decimal SaldoTotalBanco ()
    {
        decimal valorTotalBanco = 0m;
        foreach (var item in Contas)
        {
            valorTotalBanco += item.Saldo;
        }
        return valorTotalBanco;
    }
}
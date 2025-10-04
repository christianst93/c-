public static class Saude
{
    public static (double Imc, string Situacao) Imc(Pessoa pessoa)
    {
        // Estrutura de Dados: TUPLA (ordem importa)
        double imc = pessoa.peso / Math.Pow(pessoa.altura, 2);
        string situacao;
        if (imc < 17) situacao = "Muito abaixo";
        else if (imc < 18.5) situacao = "Abaixo do peso";
        else if (imc < 25) situacao = "Peso normal";
        else if (imc < 30) situacao = "Sobrepeso";
        else if (imc < 35) situacao = "Obesidade I";
        else if (imc < 40) situacao = "Obesidade I";
        else situacao = "Obesidade III";
        return (Imc: imc, Situacao: situacao);       
    }
}
//escopo: Criar uma Classe, é o MÒDULO!
//O ideal é uma Classe por arquivo
//Classe estática e pública
public static class Saude
{    
    //Os métodos (funções dentro de uma classe)
    public static double Imc(double peso, double altura)
    {
        return peso / Math.Pow(altura, 2);
    }
}
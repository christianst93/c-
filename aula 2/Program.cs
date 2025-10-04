int[] semestres = [1, 2, 3, 4, 5, 6];
string[] estadoCivil = ["Cadado(a)", "Solteiro(a)", "Divorciado(a)", "Viuvo(a)"];

String[] pessoas = ["Fulano", "Beltrano", "Cicrano", "Mariano"];
double[] alturas = new double[4];
alturas[0] = 1.70;
alturas[1] = 1.65;
alturas[2] = 1.85;
alturas[3] = 1.45;

double[] pesos = [76.4, 87.9, 56.7, 65.1];

foreach (var peso in pesos)
{
    Console.WriteLine(peso);
}

int[] idades = [43, 23, 18, 67];

Console.WriteLine(pesos.Length);

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"{pessoas[i]} altura {alturas[i]} peso {pesos[i]}");
}

Pessoa p1 = new() // instanciar e inicializar
{
    Nome = "Fulano",
    idade = 43,
    peso = 76.4,
    altura = 1.70
};

Console.WriteLine(p1);
Console.WriteLine(p1.idade);

// Lista (List)
// Lista é homogênea ou heterogênea? homogênea
List<Pessoa> povo = [];
Console.WriteLine(povo.Count);
povo.Add(new Pessoa
{
    Nome = "Pedro",
    idade = 31,
    peso = 75,
    altura = 1.70
});

povo.Add(p1);
povo.Add(p1);
Console.WriteLine(povo.Count);
Console.WriteLine(povo[0]);
// para cada elemento na coleção
// for each

foreach (var pessoa in povo)
{
    Console.WriteLine($"Pessoa {pessoa}");
}

Console.WriteLine(Saude.Imc(povo[0]));
Console.WriteLine(Saude.Imc(povo[1]));
Console.WriteLine(Saude.Imc(new Pessoa
{
    Nome = "Marcio",
    idade = 48,
    peso = 80.3,
    altura = 1.72
}));
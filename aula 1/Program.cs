var peso = 78;
var altura = 1.75;
var imc = Saude.Imc(peso, altura);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"IMC: {imc:F2}");
Console.WriteLine("Para o peso " + peso + " e altura " + altura + " o IMC é " + imc);
//interpolação de string
Console.WriteLine($"Para o peso {peso} e altura {altura} o imc é {imc:F2}");
Console.WriteLine($"Para o peso de 69Kg e altura de 1,62 o IMC é {Saude.Imc(69, 1.62):F2}");
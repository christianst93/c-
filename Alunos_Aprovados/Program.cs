using Modelo;
using Logica;

List<Aluno> alunos = new List<Aluno>() {

new Aluno { Nome = "Christian Torres", Matricula = "1955", Nota1 = 9.1f, Nota2 = 9.2f, Nota3 = 9.0f, Nota4 = 9.4f },
new Aluno { Nome = "Maria Silva", Matricula = "2001", Nota1 = 7.5f, Nota2 = 8.0f, Nota3 = 6.5f, Nota4 = 7.0f },
new Aluno { Nome = "João Almeida", Matricula = "2033", Nota1 = 5.5f, Nota2 = 6.0f, Nota3 = 5.8f, Nota4 = 6.2f },
new Aluno { Nome = "Ana Beatriz", Matricula = "2077", Nota1 = 8.8f, Nota2 = 9.1f, Nota3 = 8.9f, Nota4 = 9.0f },
new Aluno { Nome = "Carlos Mendes", Matricula = "2102", Nota1 = 4.5f, Nota2 = 5.0f, Nota3 = 4.8f, Nota4 = 5.2f },
new Aluno { Nota1 = 9.0f, Nota2 = 10.0f, Nota3 = 9.8f,}
};


foreach (var aluno in alunos)
{
    Console.WriteLine($"O aluno {aluno.Nome}, matricula {aluno.Matricula} foi {aluno.aprovado} com {aluno.media:F1}");
}

var aprovados = Info.AlunosAprovados(alunos);
Console.WriteLine("");

foreach (var aluno in aprovados)
{
    Console.WriteLine($"{aluno.Nome} esta aprovado.");
}

var reprovados = Info.AlunosReprovados(alunos);
Console.WriteLine("");

foreach (var aluno in reprovados)
{
    Console.WriteLine($"O aluno {aluno.Nome} esta reprovado.");
}

Console.WriteLine("");

var Medias = Info.Medias(alunos);

Console.WriteLine($"A maior média da turma é {Medias.maiorMedia:F1} e percente ao aluno {Medias.nomeAluno}, a media geral da turma é {Medias.mediaTurma:F1}");

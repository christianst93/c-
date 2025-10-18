using Modelo;
namespace Logica;
public class Info
{
    public static List<Aluno> AlunosAprovados(List<Aluno> alunos)
    {
        List<Aluno> aprovados = new List<Aluno>();
        foreach (var aluno in alunos)
        {
            if (aluno.media >= 7)
            {
                aprovados.Add(aluno);
            }
        }
        return aprovados;
    }

    public static List<Aluno> AlunosReprovados(List<Aluno> alunos)
    {
        List<Aluno> reprovados = new List<Aluno>();

        foreach (var aluno in alunos)
        {
            if (aluno.media < 7)
            {
                reprovados.Add(aluno);
            }
        }
        return reprovados;
    }
    
    public static (float maiorMedia, float mediaTurma, string nomeAluno) Medias (List<Aluno> alunos)
    {
        float maiorMedia = float.MinValue;
        float mediaTurma = 0;
        string nomeAluno = "";        

        foreach (var aluno in alunos)
        {
            if (aluno.media > maiorMedia)
            {
                maiorMedia = aluno.media;
                nomeAluno = aluno.Nome;
            }
            mediaTurma += aluno.media;
        }
        mediaTurma = mediaTurma / alunos.Count;

        return (maiorMedia, mediaTurma, nomeAluno);
    }
}
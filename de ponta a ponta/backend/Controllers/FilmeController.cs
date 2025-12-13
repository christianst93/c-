using Microsoft.AspNetCore.Mvc;
using backend.Models;
using Npgsql;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    // https://google.com/search?q=tads
    // virá um filme do frontend
    // vai tratar os erros
    [HttpPost]
    public ActionResult Post([FromBody] Filme filme)
    {
        if (filme.Hype < 1 || filme.Hype > 5)
        {
            return BadRequest("Hype deve ser entre 1 e 5");
        }
        Console.WriteLine("Filme recebido:");
        Console.WriteLine(filme);

        var strconexao = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=tadsflix";

        using var conexao = new NpgsqlConnection(strconexao);
        conexao.Open();
        
        var sql = "INSERT INTO filmes (titulo, genero, hype, assistido) VALUES (@titulo, @genero, @hype, true)";

        var cmd = new NpgsqlCommand(sql, conexao);

        //preencher os dados do insert
        cmd.Parameters.AddWithValue("@titulo", filme.Titulo);
        cmd.Parameters.AddWithValue("@genero", filme.genero);
        cmd.Parameters.AddWithValue("@hype", filme.Hype);
        //executar o comando no banco
        cmd.ExecuteNonQuery();
        // Fim do banco

        // INSERT
        return Ok("Filme salvo com sucesso!");
    }
    
}

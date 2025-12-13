using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class TadsController : ControllerBase
{
    
    [HttpGet]
    public String Get()
    {
        return "Análise e Desenvolvimento de Sistemas!!";
    }
}

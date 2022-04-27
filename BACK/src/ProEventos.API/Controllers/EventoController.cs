using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public EventoController()
    {
       
    }

    [HttpGet(Name = "GetEvento")]
    public Evento Get()
    {
        return new Evento{
            EventoId=1,
            Tema="Angular 11 e .Net 6",
            Local="Sao Paulo",
            Lote="1º Lote",
            QtdPessoas=250,
            DataEvento=DateTime.Now.AddDays(2).ToString()
        };
    }
}

using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{
    private readonly DataContext _context;

    public EventosController(DataContext context)
    {
        this._context = context;

    }

    [HttpGet(Name = "GetEvento")]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }
}

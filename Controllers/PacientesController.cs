using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using ilis.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class PacientesController : ControllerBase
{

    int id;
    private readonly ApplicationDbContext _context;

    public PacientesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Paciente>>> GetPacientes([FromQuery] string nome)
    {
        if (string.IsNullOrEmpty(nome))
        {
            return BadRequest();
        }
        var tmp = nome.Split(" ");
        nome = tmp[0];
        var sobrenome = tmp[1];

        var pacientes = await _context.Paciente
            .Where(p => p.Nome.Contains(nome) && p.Sobrenome.Contains(sobrenome))

            .ToListAsync();

        return Ok(pacientes);
    }

    public int getLastID()
    {
        id = 0;
        id = _context.Paciente.LastOrDefault().Id;        
        
        return id;
    }

    [HttpPost]
    public async Task<ActionResult<Paciente>> CreatePaciente(Paciente paciente)
    {
        if (ModelState.IsValid)
        {        
            _context.Paciente.Add(paciente);
            await _context.SaveChangesAsync();
            return Ok(paciente);
        }
        return BadRequest(ModelState);
    }
}
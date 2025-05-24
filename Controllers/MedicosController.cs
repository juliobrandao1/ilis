using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using ilis.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class MedicosController : ControllerBase
{

    int id;
    private readonly ApplicationDbContext _context;

    public MedicosController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Medico>>> GetMedicos([FromQuery] string nome)
    {
        if (string.IsNullOrEmpty(nome))
        {
            return BadRequest();
        }        

        var medicos = await _context.Medico
            .Where(p => p.Nome.Contains(nome) )

            .ToListAsync();

        return Ok(medicos);
    }

    public int getLastID()
    {
        id = 0;
        id = _context.Medico.LastOrDefault().Id;        
        
        return id;
    }

    [HttpPost]
    public async Task<ActionResult<Medico>> CreateMedico(Medico medico)
    {
        if (ModelState.IsValid)
        {        
            _context.Medico.Add(medico);
            await _context.SaveChangesAsync();
            return Ok(medico);
        }
        return BadRequest(ModelState);
    }
}
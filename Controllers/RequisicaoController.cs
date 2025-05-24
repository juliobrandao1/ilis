using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using ilis.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class RequisicaoController : ControllerBase
{

    int id;
    private readonly ApplicationDbContext _context;

    public RequisicaoController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Requisicao>>> GetRequisicao([FromQuery] string codRequisicao)
    {
        if (string.IsNullOrEmpty(codRequisicao))
        {
            return BadRequest();
        }


        var requisicao = await _context.Requisicao
            .Where(p => p.codRequisicao == Convert.ToInt32(codRequisicao))
            .ToListAsync();

        return Ok(requisicao);
    }



    [HttpPost]
    public async Task<ActionResult<Requisicao>> CreateRequisicao(Requisicao requisicao)
    {
        if (ModelState.IsValid)
        {
            _context.Requisicao.Add(requisicao);
            await _context.SaveChangesAsync();
            return Ok(requisicao);
        }
        return BadRequest(ModelState);
    }
}
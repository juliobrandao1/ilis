using ilis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Data;


namespace ilis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CadastroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // Exibir o formulário
        [HttpGet]
        public IActionResult Index()
        {
            var model = new Cadastro();
            var requisicao = new Requisicao();
            //{
            //    Numero = "003-701439",
            //    Paciente = "Novo Paciente",
            //    Medico = "0000",
            //    Posto = "Montenegro - Guarujá",
            //    Contrato = "",
            //    Plano = "",
            //    DataPedido = DateTime.Now,
            //    Genero = "Indeterminado",
            //    Email = ""
            //};

            return View(model);
        }

        // Processar o formulário
        [HttpPost]
        public IActionResult Index(Cadastro model)
        {
            if (ModelState.IsValid)
            {
                // Salvar os dados ou realizar alguma ação
                TempData["Mensagem"] = "Dados salvos com sucesso!";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        [Route("api/[controller]/create")]
        public IActionResult CreateRequisicao(Requisicao requisicao)
        {
            if (ModelState.IsValid)
            {
                  _context.Requisicao.Add(requisicao);
                _context.SaveChanges();
                return Ok(requisicao);
            }
            return BadRequest(ModelState);
        }
    }
}
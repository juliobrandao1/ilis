using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using System;

namespace ilis.Controllers
{
    public class PedidoController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PedidoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int chave = 0, string paciente = "0", string origem = "", string cns = "", string altera = "N")
        {
            // Simulação de dados para exemplo. Substitua por lógica real.
            var model = new Models.Pedido
            {
                Chave = chave,
                Paciente = paciente,
                Origem = origem,
                CNS = cns,
                Altera = altera,
                mSexo = "M", // Exemplo: Masculino
                mCarteirinha = "S", // Exemplo: Preferencial
                mCodigoAcesso = "123456", // Código de Acesso Simulado
                mTelefone = "(11) 98765-4321",
                mEmail = "email@exemplo.com",
                mCelular = "(11) 91234-5678",
                mNascimento = DateTime.Parse("2000-01-01") // Data de nascimento
            };

            // Cálculo de idade
            if (model.mNascimento.HasValue)
            {
                DateTime hoje = DateTime.Now;
                var nascimento = model.mNascimento.Value;

                model.Anos = hoje.Year - nascimento.Year;
                if (nascimento > hoje.AddYears(-model.Anos)) model.Anos--;

                model.Meses = hoje.Month - nascimento.Month;
                if (model.Meses < 0)
                {
                    model.Meses += 12;
                    model.Anos--;
                }

                model.Dias = hoje.Day - nascimento.Day;
                if (model.Dias < 0)
                {
                    model.Meses--;
                    model.Dias += DateTime.DaysInMonth(hoje.Year, hoje.Month - 1);
                }
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> SearchPaciente(string searchTerm)
        {
            var viewModel = new Models.PacienteSearchView
            {
                SearchTerm = searchTerm,
                Pacientes = string.IsNullOrEmpty(searchTerm) ? null : await _context.Paciente
                    .Where(p => p.Nome.Contains(searchTerm))
                    .ToListAsync()
            };

            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> SearchMedico(string searchTerm)
        {
            var viewModel = new Models.MedicoSearchView
            {
                SearchTerm = searchTerm,
                Medicos = string.IsNullOrEmpty(searchTerm) ? null : await _context.Medico
                    .Where(p => p.Nome.Contains(searchTerm))
                    .ToListAsync()
            };

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Submit(Models.Pedido model)
        {
            // Processar o formulário aqui. Exemplo:
            if (!string.IsNullOrEmpty(model.mCPF))
            {
                // Validar CPF e salvar no banco, se necessário.
            }

            return RedirectToAction("Index", new { chave = model.Chave, paciente = model.Paciente });
        }
    }

}
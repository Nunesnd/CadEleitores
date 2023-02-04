using CadEleitores.Models;
using CadEleitores.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CadEleitores.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<PessoaModel> pessoas = _contatoRepositorio.BuscarTodos();
            return View(pessoas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult CriaEndereco()
        {
            return View();
        }

        public IActionResult Detalhes()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirma()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(PessoaModel pessoa)
        {
            _contatoRepositorio.Adicionar(pessoa);
            return RedirectToAction("CriaEndereco");
        }
    }
}

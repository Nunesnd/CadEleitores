using CadEleitores.Models;
using CadEleitores.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CadEleitores.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProfissaoRepositorio _profissaoRepositorio;
        public HomeController(IProfissaoRepositorio profissaoRepositorio)
        {
            _profissaoRepositorio = profissaoRepositorio;
        }
        public IActionResult Index()
        {
            List<ProfissaoModel> profissao = _profissaoRepositorio.BuscarTodos();
            return View(profissao);
        }

        public IActionResult Profissao()
        {
            return View();
        }

        public IActionResult ProfissaoLista()
        {
            //List<ProfissaoModel> profissao = _profissaoRepositorio.BuscarTodos();
            //return View(profissao);
            return View();
        }

        [HttpPost]
        public IActionResult Profissao(ProfissaoModel profissao)
        {
            _profissaoRepositorio.Adicionar(profissao);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
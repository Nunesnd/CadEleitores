using Microsoft.AspNetCore.Mvc;

namespace CadEleitores.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

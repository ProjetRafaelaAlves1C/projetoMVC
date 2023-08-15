using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult  Criar()
        {
            return View();
        }
        public IActionResult Atualizar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }
    }
}

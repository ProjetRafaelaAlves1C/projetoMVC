using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

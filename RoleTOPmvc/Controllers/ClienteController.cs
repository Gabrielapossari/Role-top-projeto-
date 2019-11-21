using Microsoft.AspNetCore.Mvc;

namespace RoleTOPmvc.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
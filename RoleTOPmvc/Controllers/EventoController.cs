using Microsoft.AspNetCore.Mvc;

namespace RoleTOPmvc.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult eventos()
        {
            return View();
        }
    }
}
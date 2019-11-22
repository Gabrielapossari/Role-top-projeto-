using System;
using Microsoft.AspNetCore.Mvc;

namespace RoleTOPmvc.Controllers
{
    public class CadastroController
    {
        public IActionResult cadastro()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
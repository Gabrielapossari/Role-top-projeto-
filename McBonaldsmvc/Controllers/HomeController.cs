using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using McBonaldsMVC.Models;
using McBonaldsmvc.ViewModels;

namespace McBonaldsMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel(){
                NomeView = "Home",
                UsuarioNome = ObterUsuarioSession()
                UsuarioEmail = ObterUsuarioSession()
                
            });
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
}

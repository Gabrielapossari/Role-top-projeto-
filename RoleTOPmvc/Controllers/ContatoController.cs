using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Models;
using RoleTOPMVC.ViewModels;

namespace RoleTOPMVC.Controllers
{
    public class ContatoController : AbstractController 
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Contato",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            
        }
    }
}
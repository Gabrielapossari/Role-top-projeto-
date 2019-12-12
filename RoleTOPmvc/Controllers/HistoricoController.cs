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
    public class HistoricoController : AbstractController 
    {
        public IActionResult Historico()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                TiposUsuario = 0
            });
            
        }
        
    }
}
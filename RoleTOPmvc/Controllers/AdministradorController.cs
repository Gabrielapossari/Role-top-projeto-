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
    public class AdministradorController : AbstractController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
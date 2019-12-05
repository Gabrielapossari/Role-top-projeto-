using System;
using RoleTOPMVC.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;

namespace RoleTOPMVC.Controllers

{  
        public class RegistrarController : AbstractController    

        {
            private ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            return View();
        }
        }
}
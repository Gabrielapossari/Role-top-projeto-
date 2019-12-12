using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;


namespace RoleTOPMVC.Controllers
{
    public class ContratarController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            AgendamentoViewModel avm = new AgendamentoViewModel();
            var emailcliente = ObterUsuarioSession();
            var cliente = clienteRepository.ObterPor(emailcliente);
            if(cliente != null){
                avm.cliente = cliente;
                return View(avm);   
            }
            else{
                return View(avm);
            } 
        }
        
    }
}
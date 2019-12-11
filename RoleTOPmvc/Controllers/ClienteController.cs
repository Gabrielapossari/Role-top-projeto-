using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Controllers;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;

namespace RoleTOPMVC.Controllers

{
    public class ClienteController : AbstractController

    {
        private EventoRepository eventoRepository = new EventoRepository();
        private ClienteRepository clienteRepository = new ClienteRepository ();
        [HttpGet]
        public IActionResult Index () {
            return View (new BaseViewModel () {
                    NomeView = "Cliente",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()
            });
        }
        
    
        public IActionResult Historico ()
        {
            var emailCliente = ObterUsuarioSession();
            var  EventosCliente = eventoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Eventos  = EventosCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
        });
        }
        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
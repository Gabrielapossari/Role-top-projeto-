using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RoleTOPMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Models;
using RoleTOPMVC.ViewModels;
using RoleTOPMVC.Enums;

namespace RoleTOPMVC.Controllers
{
    public class EventoController : AbstractController
    {
        private ClienteRepository clienterepository = new ClienteRepository();
        private EventoRepository eventoRepository = new EventoRepository();

        [HttpGet]
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Evento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
            public IActionResult CadastrarEvento(IFormCollection form)
            {
                try {
                    Cliente cliente = new Cliente()
                    {
                    Nome = form["Nome"],
                    Email = form["Email"]
                    };
                    Evento evento = new Evento
                    ( 
                    // clienterepository.ObterPor(ObterUsuarioSession()),
                    DateTime.Parse(form["DataFesta"]),
                    form["TipoFesta"],
                    form["QuantsPessoas"],
                    form["Horario"],
                    form["Servicos"],
                    form["Espacos"]);
                    evento.Cliente = cliente;
                    eventoRepository.Inserir(evento);
                    
                return View("Sucesso", new RespostaViewModel("Evento cadastrado!"));
            } 
        
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Não foi possivel cadastrar o evento!"));
            }
        }
        
        public IActionResult Aprovar(ulong Id)
        {
            var eventos = eventoRepository.ObterPor(Id);
            eventos.Status = (uint) StatusEvento.APROVADO;

            if(eventoRepository.Atualizar(eventos))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

        public IActionResult Reprovar(ulong Id)
        {
            var evento = eventoRepository.ObterPor(Id);
            evento.Status = (uint) StatusEvento.REPROVADO;

            if(eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
    }
}
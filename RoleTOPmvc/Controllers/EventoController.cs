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

namespace RoleTOPMVC.Controllers
{
    public class EventoController : AbstractController
    {
        public IActionResult Index()
        {
            return View();
        }
        private ClienteRepository clienterepository = new ClienteRepository();
        private EventoRepository eventoRepository = new EventoRepository();
            public IActionResult CadastrarEvento(IFormCollection form)
            {
                ViewData["Action"] = "Evento";
                try {
                    Evento evento = new Evento
                    (
                    clienterepository.ObterPor(ObterUsuarioSession()),
                    form["nome"],
                    form["email"],
                    DateTime.Parse(form["DataFesta"]),
                    form["TipoFesta"],
                    form["QuantsPessoas"],
                    int.Parse(form["Horario"]),
                    form["Servicos"],
                    form["Espacos"]);
                        
                    eventoRepository.Inserir(evento);
                    
                    return View("Sucesso");
                } 
                catch(Exception e)
                {
                    return View("Erro");
                }
            }
    }
}
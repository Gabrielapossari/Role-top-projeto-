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
        private ClienteRepository clienterepository = new ClienteRepository();
        private EventoRepository eventoRepository = new EventoRepository();

        [HttpGet]
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Evento"
            });
        }

        [HttpPost]
            public IActionResult CadastrarEvento(IFormCollection form)
            {
                try {
                    Evento evento = new Evento
                    (
                    // clienterepository.ObterPor(ObterUsuarioSession()),
                    form["Nome"],
                    form["Email"],
                    DateTime.Parse(form["DataFesta"]),
                    form["TipoFesta"],
                    form["QuantsPessoas"],
                    form["Horario"],
                    form["Servicos"],
                    form["Espacos"]);
                    eventoRepository.Inserir(evento);
                    
                return View("Sucesso", new RespostaViewModel("Evento cadastrado!"));
            } 
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Não foi possivel cadastrar o evento!"));
            }
        }
    }
}

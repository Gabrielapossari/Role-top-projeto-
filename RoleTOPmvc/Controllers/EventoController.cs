using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;

namespace RoleTOPMVC.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private EventoRepository eventoRepository = new EventoRepository();
            public IActionResult CadastrarEvento(IFormCollection form)
            {
                ViewData["Action"] = "Cliente";
                try {
                    Evento evento = new Evento
                    (form["cliente_nome"],
                    form["cliente_email"],
                    form["evento_DataFesta"],
                    form["evento_TipoFesta"],
                    form["evento_QuantsPessoas"],
                    form["evento_Horario"],
                    form["evento_Servicos"]);
                        
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
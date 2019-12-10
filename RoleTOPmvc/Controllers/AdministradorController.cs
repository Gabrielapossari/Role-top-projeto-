using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;

namespace RoleTOPMVC.Controllers {
    public class AdministradorController : AbstractController {
        EventoRepository eventorepository = new EventoRepository ();
        public IActionResult Dashboard () {
            {
                if (ObterUsuarioSession () == "admin@hotmail.com") {
                    var eventos = eventorepository.ObterTodos ();
                    DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                    foreach (var evento in eventos) {
                        switch (evento.Status) {
                            case (uint) StatusEvento.APROVADO:
                                dashboardViewModel.EventosAprovados++;
                                break;
                            case (uint) StatusEvento.REPROVADO:
                                dashboardViewModel.EventosReprovados++;
                                break;
                            default:
                                dashboardViewModel.EventosPendentes++;
                                dashboardViewModel.Eventos.Add (evento);
                                break;
                        }
                    }

                    return View (dashboardViewModel);
                } else {
                    return View ("Erro", new RespostaViewModel () {
                        NomeView = "Dashboard",
                            Mensagem = "Você não tem permissão para acessar o Dashboard"
                    });
                }
            }
        }
    }
}
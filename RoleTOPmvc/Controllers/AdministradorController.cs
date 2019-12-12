using RoleTOPMVC.Enums;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Controllers;

namespace RoleTOPMVC.Controllers {
    public class AdministradorController : AbstractController {
        EventoRepository eventoRepository = new EventoRepository();
        public IActionResult Dashboard () {

            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && 
            (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())) {

                var eventos = eventoRepository.ObterTodos();
                DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                foreach (var evento in eventos ) {
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
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();
                dashboardViewModel.TiposUsuario = 0;

                return View (dashboardViewModel);
            } 
            else 
            {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });

            }
        }
    }
}
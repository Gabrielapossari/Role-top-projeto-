using System.Collections.Generic;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public uint EventosAprovados {get;set;}
        public uint EventosReprovados {get;set;}
        public uint EventosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Eventos = new List<Evento>();
        }

    }
}
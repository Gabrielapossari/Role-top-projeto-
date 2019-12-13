using System.Collections.Generic;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public Evento evento {get;set;}
        public List<Evento> Evento {get;set;}
        public HistoricoViewModel() {
            this.Evento = new List<Evento>();
        }
    }
}
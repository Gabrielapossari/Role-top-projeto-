using System.Collections.Generic;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        
        public List<Evento> Eventos {get;set;}
        public HistoricoViewModel()
        {
            this.Eventos= new List<Evento>();
            
        }
    }
}
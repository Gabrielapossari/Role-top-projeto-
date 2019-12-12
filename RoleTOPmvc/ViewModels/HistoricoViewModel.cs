using System.Collections.Generic;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Evento> Evento {get;set;}
    }
}
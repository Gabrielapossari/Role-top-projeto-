using RoleTOPMVC.Models;
using RoleTOPMVC.Enums;
using System.Collections.Generic;

namespace RoleTOPMVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Cliente cliente {get;set;}

        public AgendamentoViewModel() {
            this.cliente= new Cliente();
        }
    }

}
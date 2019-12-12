using RoleTOPMVC.Models;
using RoleTOPMVC.Enums;
using System.Collections.Generic;

namespace RoleTOPMVC.ViewModels
{
    public class BaseViewModel
    {
        public string NomeView {get;set;}
        public string UsuarioNome {get;set;}
        public string UsuarioEmail {get;set;}
        public int TiposUsuario {get;set;}
        public List<Evento> Eventos {get;set;}

        public BaseViewModel(){
            this.TiposUsuario = -1;
        }
    }
}
using System;
using RoleTOPMVC.Enums;

namespace RoleTOPMVC.Models
{
    public class Evento
    {
        public ulong Id {get;set;}
        public uint Status {get;set;}
        public DateTime DataFesta {get;set;}
        public string TipoFesta {get;set;}
        public string QuantsPessoas {get;set;}
        public string Horario {get;set;}
        public string Servicos {get;set;}
        public string Espacos {get;set;}
        public Cliente Cliente {get;set;}
        public Evento()
        {
            this.Cliente = new Cliente();

        }
        
        public Evento (DateTime DataFesta,string TipoFesta,string QuantsPessoas,string Horario,string Servicos,string espacos){
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (uint) StatusEvento.PENDENTE; 
            this.DataFesta = DataFesta;
            this.TipoFesta = TipoFesta;
            this.QuantsPessoas = QuantsPessoas;
            this.Horario = Horario;
            this.Servicos=Servicos;
            this.Espacos=espacos;
            
        }
    }
}
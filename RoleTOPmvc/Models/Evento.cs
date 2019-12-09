using System;

namespace RoleTOPMVC.Models
{
    public class Evento
    {
        public string Nome {get;set;}
        public string Email {get;set;}
        public DateTime DataFesta {get;set;}
        public string TipoFesta {get;set;}
        public string QuantsPessoas {get;set;}
        public string Horario {get;set;}
        public string Servicos {get;set;}
        public string Espacos {get;set;}
        public Cliente Cliente {get;set;}

        public Evento()
        {

        }
        
        public Evento (string Nome,string Email,DateTime DataFesta,string TipoFesta,string QuantsPessoas,string Horario,string Servicos,string espacos){
            this.Cliente = new Cliente();
            this.Nome =Nome;
            this.Email=Email;
            this.DataFesta = DataFesta;
            this.TipoFesta = TipoFesta;
            this.QuantsPessoas = QuantsPessoas;
            this.Horario = Horario;
            this.Servicos=Servicos;
            this.Espacos=espacos;
            //this.Status = (uint) StatusPedido.PENDENTE; 
        }
    }
}
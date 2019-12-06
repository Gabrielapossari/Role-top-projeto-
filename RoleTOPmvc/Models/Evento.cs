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
        public int Horario {get;set;}
        public string Servicos {get;set;}
        public string Espacos {get;set;}
        public Cliente Cliente {get;set;}
        
        public Evento (Cliente cliente ,string nome,string email,DateTime DataFesta,string TipoFesta,string QuantsPessoas,int Horario,string Servicos,string espacos){
            this.Cliente = cliente;
            this.Nome=nome;
            this.Email = email;
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
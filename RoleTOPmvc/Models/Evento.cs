using System;
using Microsoft.Extensions.Primitives;

namespace RoleTOPMVC.Models
{
    public class Evento
    {
        private StringValues stringValues;
        private StringValues stringValues1;
        private StringValues stringValues2;
        private StringValues stringValues3;
        private StringValues stringValues4;
        private StringValues stringValues5;
        private StringValues stringValues6;
        private StringValues stringValues7;

        public Cliente Cliente {get;set;}
        public uint Status {get;set;}
        public ulong Id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public DateTime DataFesta {get;set;}
        public string TipoFesta {get;set;}
        public string QuantPessoas {get;set;}
        public string Horario {get;set;}
        public string Servicos {get;set;}
        public string PrecoTotal {get;set;}
        public Evento (string status,string id,string nome,string email,DateTime DataFesta,string TipoFesta,string QuantPessoas,
        string Horario,string Servicos,string PrecoTotal){
            this.Nome=nome;
            this.Email = email;
            this.DataFesta = DataFesta;
            this.TipoFesta = TipoFesta;
            this.QuantPessoas = QuantPessoas;
            this.Servicos=Servicos;
            this.Horario = Horario;
            this.Id = 0;
            //this.Status = (uint) StatusPedido.PENDENTE; 
        }
        public Evento()
        {
        }

        public Evento(StringValues stringValues1, StringValues stringValues2, StringValues stringValues3, StringValues stringValues4, StringValues stringValues5, StringValues stringValues6, StringValues stringValues7)
        {
            this.stringValues1 = stringValues1;
            this.stringValues2 = stringValues2;
            this.stringValues3 = stringValues3;
            this.stringValues4 = stringValues4;
            this.stringValues5 = stringValues5;
            this.stringValues6 = stringValues6;
            this.stringValues7 = stringValues7;
        }
    }
}
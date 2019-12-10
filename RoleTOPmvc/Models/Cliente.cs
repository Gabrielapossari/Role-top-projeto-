using System;

namespace RoleTOPMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string CPF {get;set;}
        public string Senha {get;set;}

        public uint TipoUsuario {get;set;}

        public Cliente (string Nome,string endereco,string telefone,string cpf,string email,string senha){
            
            this.Nome=Nome;
            this.Endereco=endereco;
            this.Telefone=telefone;
            this.CPF=cpf;
            this.Email=email;
            this.Senha=senha;
        }

        public Cliente()
        {
        }
    }
}
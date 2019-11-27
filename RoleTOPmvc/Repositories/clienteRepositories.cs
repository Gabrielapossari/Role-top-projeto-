
using System;
using RoleTOPMVC.Models;
using System.IO;


namespace RoleTOPMVC.Repositories{
    public class clienteRepositories {
        private const string PATH = "Database/cliente.csv";
        
        public clienteRepositories(){
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }
        public bool Inserir (Cliente cliente) 
        {
            var linha = new string[] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);
            
            return true;
        }

            private string PrepararRegistroCSV (Cliente cliente)
        {
            return $"nome={cliente.Nome};endereco={cliente.Endereco};Telefone={cliente.Telefone};cpf={cliente.CPF};email={cliente.Email};senha={cliente.Senha}";
        }
    }
}
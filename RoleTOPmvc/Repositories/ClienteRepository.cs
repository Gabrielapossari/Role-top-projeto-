
using System;
using RoleTOPMVC.Models;
using System.IO;


namespace RoleTOPMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/cliente.csv";
        
        public ClienteRepository(){
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
        public Cliente ObterPor (string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.Endereco = ExtrairValorDoCampo("endereco", item);
                    c.Telefone = ExtrairValorDoCampo("telefone", item);
                    c.CPF = ExtrairValorDoCampo("cpf", item);
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);

                    return c;
                }
            }
            return null;
        }
            private string PrepararRegistroCSV (Cliente cliente)
        {
            return $"nome={cliente.Nome};endereco={cliente.Endereco};telefone={cliente.Telefone};cpf={cliente.CPF};email={cliente.Email};senha={cliente.Senha}";
        }

    }
}
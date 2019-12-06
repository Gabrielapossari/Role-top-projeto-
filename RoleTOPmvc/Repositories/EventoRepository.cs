using System;
using System.Collections.Generic;
using System.IO;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;

namespace RoleTOPMVC.Repositories
{
    public class EventoRepository : RepositoryBase 
    {
        private const string PATH = "Database/evento.csv";
        public EventoRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Evento evento) 
        {
            var linha = new string[] { PrepararPedidoCSV(evento) };
            File.AppendAllLines(PATH, linha);
            return true;
        }

        private string PrepararPedidoCSV (Evento evento) {
            
            Cliente c = evento.Cliente;

            return $"nome={c.Nome};email={c.Email};DataFesta={evento.DataFesta};TipoFesta={evento.TipoFesta};QuantsPessoas={evento.QuantsPessoas};Horario={evento.Horario};Servicos={evento.Servicos}";
        }
    }
}
    

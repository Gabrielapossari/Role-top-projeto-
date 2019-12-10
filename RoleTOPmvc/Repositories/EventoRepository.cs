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
            public List<Evento> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<Evento> eventos = new List<Evento>();

            foreach (var linha in linhas) {
                Evento evento = new Evento ();
                evento.Nome = ExtrairValorDoCampo("Nome", linha);
                evento.Email = ExtrairValorDoCampo("Email",linha);
                evento.DataFesta = DateTime.Parse(ExtrairValorDoCampo("DataFesta", linha));
                evento.TipoFesta = ExtrairValorDoCampo("TipoFesta", linha);
                evento.QuantsPessoas = ExtrairValorDoCampo("QuantsPessoas", linha);
                evento.Horario = ExtrairValorDoCampo("Horario",linha);
                evento.Servicos = ExtrairValorDoCampo("Servicos", linha);
                evento.Espacos = ExtrairValorDoCampo("Espacos", linha);
                eventos.Add(evento);
            }
            return eventos;
        }
        private string PrepararPedidoCSV (Evento evento) {
            
            Cliente c = evento.Cliente;

            return $"Nome={evento.Nome};Email={evento.Email};DataFesta={evento.DataFesta};TipoFesta={evento.TipoFesta};QuantsPessoas={evento.QuantsPessoas};Horario={evento.Horario};Servicos={evento.Servicos};Espacos={evento.Espacos}";
        }
    }
}
    

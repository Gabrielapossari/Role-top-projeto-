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
        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos();
            List<Evento> EventosCliente = new List<Evento>();

            foreach (var Evento in eventos)
            {
                if(Evento.Email.Equals(emailCliente))
                {
                    EventosCliente.Add(Evento);
                }
            }
            return EventosCliente;
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

            return $"status_cliente={evento.Status};Nome={evento.Nome};Email={evento.Email};DataFesta={evento.DataFesta};TipoFesta={evento.TipoFesta};QuantsPessoas={evento.QuantsPessoas};Horario={evento.Horario};Servicos={evento.Servicos};Espacos={evento.Espacos}";
        }
        public Evento ObterPor(ulong id)
        {
            var eventosTotais = ObterTodos();
            foreach (var evento in eventosTotais)
            {
                if(id.Equals(evento.Id))
                {
                    return evento;
                }
            }
            return null;
        }

        public bool Atualizar(Evento evento)
        {
            var eventosTotais = File.ReadAllLines(PATH);
            var eventoCSV = PrepararPedidoCSV(evento);
            var linhaPedido = -1;
            var resultado = false;
            
            for (int i = 0; i < eventosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", eventosTotais[i]));
                if(evento.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                eventosTotais[linhaPedido] = eventoCSV;
                File.WriteAllLines(PATH, eventosTotais);
            }

            return resultado;
        }
    }
}
    

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
                File.Create (PATH).Close();
            }
        }
        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos();
            List<Evento> EventosCliente = new List<Evento>();

            foreach (var Evento in eventos)
            {
                if(Evento.Cliente.Email.Equals(emailCliente))
                {
                    EventosCliente.Add(Evento);
                }
            }
            return EventosCliente;
        }
            public bool Inserir (Evento evento) {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            evento.Id = (ulong) ++quantidadePedidos; 
            var linha = new string[] {PrepararPedidoCSV (evento) };
            File.AppendAllLines (PATH,linha);

            return true;
        }
            public List<Evento> ObterTodos() {
            var linhas = File.ReadAllLines (PATH);
            List<Evento> eventos = new List<Evento>();
            foreach (var linha in linhas) {
                Evento evento = new Evento ();
                evento.Id = ulong.Parse(ExtrairValorDoCampo("Id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status_cliente", linha));
                evento.Cliente.Nome = ExtrairValorDoCampo("Nome", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("Email",linha);
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
        public Evento ObterPor(ulong Id)
        {
            var eventosTotais = ObterTodos();
            foreach (var evento in eventosTotais)
            {
                if(Id.Equals(evento.Id))
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
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("Id", eventosTotais[i]));
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
        private string PrepararPedidoCSV (Evento evento) {
            
            Cliente c = evento.Cliente;

            return $"Id={evento.Id};status_cliente={evento.Status};Nome={evento.Cliente.Nome};Email={evento.Cliente.Email};DataFesta={evento.DataFesta};TipoFesta={evento.TipoFesta};QuantsPessoas={evento.QuantsPessoas};Horario={evento.Horario};Servicos={evento.Servicos};Espacos={evento.Espacos}";
        }
    }
}
    

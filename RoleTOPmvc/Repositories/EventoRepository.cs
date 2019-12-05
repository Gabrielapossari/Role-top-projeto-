using System;
using System.Collections.Generic;
using System.IO;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;

namespace McBonaldsMVC.Repositories
{
    public class EventoRepository : RepositoryBase 
    {
        private const string PATH = "Database/evento.csv";
        public EventoRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }

        }
        public bool Inserir (Evento evento) {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            evento.Id = (ulong) ++quantidadePedidos;
            var linha = new string[] { PrepararPedidoCSV (evento) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        private string PrepararPedidoCSV (Evento evento) {
            Cliente c = evento.Cliente;

            return $"id={evento.Id};status_pedido={evento.Status};cliente_nome={c.Nome};cliente_email={c.Email};evento_DataFesta={evento.DataFesta};evento_TipoFesta={evento.TipoFesta};evento_QuantsPessoas={evento.QuantPessoas};evento_Horario={evento.Horario};evento_Servicos={evento.Servicos};evento_PrecoTotal={evento.PrecoTotal};";
        }
    }
}
    

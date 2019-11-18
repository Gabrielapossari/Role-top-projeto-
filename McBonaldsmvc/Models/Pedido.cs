using System;


namespace McBonaldsMVC.Models
{
    public class Pedido
    {
        public Cliente Cliente {get;set;}

        public DateTime DataDoPedido {get;set;}
        public Hamburguer Hamburguer {get;internal set;}

        public double PrecoTotal {get;set;}
        public Shake Shake { get; internal set; }
    }
}
using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class DashboradViewModel : BaseViewModel
    {
        public List<Pedido> Pedidos {get;set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendentes  {get;set;}
        public DashboradViewModel()
        {
            this.Pedidos = new List<Pedido>();
        }

    }
}
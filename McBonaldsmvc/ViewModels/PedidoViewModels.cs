using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsmvc.ViewModels

{
    public class PedidoViewModels
    {
        public List<Hamburguer> Hamburgueres {get;set;}


        public List<Shake> Shakes {get;set;}
        

        public PedidoViewModels()
        {
            this.Shakes = new List<Shake>();
            this.Hamburgueres = new List<Hamburguer>();
        }
    }
}

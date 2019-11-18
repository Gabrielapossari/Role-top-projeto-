using System;
using McBonaldsmvc.ViewModels;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace McBonaldsMVC.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepository pedidoRepository = new PedidoRepository();

        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        public IActionResult Index()
        {
            var hamburgueres = hamburguerRepository.ObterTodos();
            var shakes = ShakeRepository.ObterTodos();
            PedidoViewModels pedido = new PedidoViewModels();
            pedido.Hamburgueres = hamburgueres;
            pedido.Shakes = shakes;
            return View(pedido);

        }

        public IActionResult Registrar(IFormCollection form )
        {
            Pedido pedido = new Pedido();
            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;
            pedido.Shake = shake;


            Hamburguer hamburguer = new Hamburguer(form["hamburguer"],hamburguerRepository.ObterPrecoDe(form["hamburguer"]));
            Shake shake = new Shake (form["shake"],shakeRepository.ObterPrecoDe(form["shake"]));

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;
            pedido.Hamburguer = hamburguer;

            pedido.DataDoPedido = DateTime.Now;
            pedido.PrecoTotal = 0.0;

            pedidoRepository.Inserir(pedido);
            

            return View("Sucesso");
        }
    }
}
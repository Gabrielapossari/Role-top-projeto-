using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;

namespace McBonaldsmvc.Controllers
{
    public class CadastroController : Controller
    {
        ClienteRepository clienteRepositorio = new ClienteRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form) {         /*Devolver uma página IActionResult */
            ViewData["Action"] = "Cadastro";
            try{
            Cliente cliente = new Cliente(
            form["nome"],
            form["endereco"],
            form["telefone"],
            form["senha"],
            form["email"],
            DateTime.Parse(form["data-nascimento"]));

            clienteRepositorio.Inserir(cliente);
            
            return View("Sucesso"); 

            }catch (Exception e )
            {
            return View("erro");
            }
        }     
    }
}

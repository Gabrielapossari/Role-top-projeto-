using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

using McBonalsMVC.Models;

namespace McBonaldsmvc.Controllers
{
    public class CadastroController : Controller
    {
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
            return View("Sucesso"); 

            }catch (Exception e )
            {
            return View("erro");
            }
        }     
    }
}

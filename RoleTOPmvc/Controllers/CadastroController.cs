using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;

namespace RoleTOPMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        private ClienteRepository clienterepositories = new ClienteRepository();
            public IActionResult CadastrarCliente(IFormCollection form)
            {
                ViewData["Action"] = "Cadastro";
                try {
                    Cliente cliente = new Cliente(
                        form["nome"], 
                        form["endereco"], 
                        form["telefone"],
                        form["cpf"],
                        form["email"],
                        form["senha"]
                    );
                        
                    clienterepositories.Inserir(cliente);
                    
                    return View("Sucesso");
                } 
                catch(Exception e)
                {
                    return View("Erro");
                }
            }
    }
}
    
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;

namespace RoleTOPMVC.Controllers
{
    public class CadastroController : AbstractController 
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
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

                    cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                        
                    clienterepositories.Inserir(cliente);
                
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    
                    
                });
            } 
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    
                });
            }
        }
    }
}
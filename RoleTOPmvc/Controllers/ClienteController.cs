using System;
using RoleTOPMVC.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;

namespace RoleTOPMVC.Controllers

{  
        public class ClienteController : AbstractController    

        {
            private ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            return View();
        }
            public IActionResult Login()
        {
                return View (new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("==================");
                System.Console.WriteLine(form["nome"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("==================");

                var usuario = form["nome"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                        
                        return View("Index","Cliente");
                    }
                    else 
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }
                } 
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View();
            }
        }
        }
}
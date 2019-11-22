using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsmvc.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "cliente_email";
        protected const string SESSION_CLIENTE_NOME = "cliente_nome";

        protected string ObterUsuarioSession()
        {
            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if(string.IsNullOrEmpty(nome)){
                return nome;
            }else{
                return "";
            }

        }
    }
}
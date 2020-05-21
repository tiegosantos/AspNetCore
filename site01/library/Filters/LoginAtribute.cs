using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Library.Filters
{
    public class LoginAtribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // verificar se a sessao existe
            if (context.HttpContext.Session.GetString("Login") == null)
            {

                if (context.Controller != null)
                {

                    Controller controlador = context.Controller as Controller;
                    controlador.TempData["MensagemErro"] = "Faça o login para ter permissão de entrar";

                
                }

                //redirecionar
                context.Result = new RedirectToActionResult("Login", "Home", null);

            }
        }
    }
}

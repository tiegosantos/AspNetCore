using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using site01.library.Mail;
using site01.Models;

namespace site01.Controllers
{
    public class ContatoController : Controller
    {
       // private StringValues Email;
      //  private StringValues Assunto;
       // private StringValues Mensagem;

        //public StringValues Nome { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        //dados automaticos
        public IActionResult ReceberContato([FromForm]Contato contato)
        {

            if (ModelState.IsValid)

            {

                //string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                //return new ContentResult() { Content = conteudo };
                                
                EnviarEmail.EnviarMensagemContato(contato);
                ViewBag.Mensagem = "Mensagem enviada com sucesso";
                return View("Index");

            }
            else
            {
                
             return View("Index");      
                            
            }

        }

        /* obter dados manualmente
          public IActionResult ReceberContato()
  /*
          {
              //Post  - Request.form
              //Get   - Request.QueryString
              Contato contato = new Contato();
              {
                  contato.Nome = Request.Form["nome"];
                  contato.Email = Request.Form["email"];
                  contato.Assunto = Request.Form["assunto"];
                  contato.Mensagem = Request.Form["mensagem"];

                  string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                  return new ContentResult() { Content = conteudo };

              }
              */
    }

    }

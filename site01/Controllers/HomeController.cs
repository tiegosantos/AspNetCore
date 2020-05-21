using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //return new ContentResult() { Content = "olá mundo fdp", ContentType = "text/json" };
            return View();

        }
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm]Usuario usuario)
        {

            if (ModelState.IsValid)  {

                if (usuario.Email == "tiego.santos@hotmail.com" && usuario.Senha == "123456")
                {

                    /*
                      * Add session
                      * HttpContext.Session.SetString("Login", "true");
                      * HttpContext.Session.SetInt32("UserID"  , 32);
                      *  HttpContext.Session.SetString("Login", Serializar Object > String);

                      * ler session
                      * string login = HttpContext.Session.GetString("Login");
                      */
                  
                HttpContext.Session.SetString("Login", "true");
                return RedirectToAction("Index", "Palavra");
                }
                else {

                    ViewBag.Mensagem = "os dados informados são invalidos";
                    return View();
                }
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");

        }

    }
}

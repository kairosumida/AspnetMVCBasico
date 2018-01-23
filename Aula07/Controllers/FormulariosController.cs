using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula07.Controllers
{
    public class FormulariosController : Controller
    {
        // GET: Formularios
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult VerificaLogin()
        {
            string email = "";
            string senha = "";
            email = Request["txtEmail"].ToString();
            senha = Request["txtSenha"].ToString();
            if(senha.Length > 3)
            {
                ViewBag.Email = email;
                ViewBag.Senha = senha;
                return View("BemVindo");
            }
            else
            {
                ViewBag.Alerta = "A senha deve ter no minímo 4 caracteres";
                return View("Login");
            }
        }
        public ActionResult BemVindo()
        {
            return View();
        }
    }
}
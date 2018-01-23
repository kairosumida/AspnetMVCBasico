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
        public ActionResult Cadastrar()
        {
            return View();
        }
        public ActionResult NovoLogin()
        {
            return View();
        }
        public ActionResult CadastrarLogin()
        {
            var nome = "";
            var email = "";
            var senha = "";
            var repetir = "";
            var lembrete = "";
            var sexo = "";
            var estadoCivil = "";
            var concordo = "";
            nome = Request["txtNome"].ToString();
            email = Request["txtEmail"].ToString();
            senha = Request["txtSenha"].ToString();
            repetir = Request["txtRepetir"].ToString();
            lembrete = Request["txtLembrete"].ToString();
            sexo = Request["rdbSexo"].ToString();
            estadoCivil = Request["chbEstadoCivil"].ToString();
            switch (estadoCivil)
            {
                case "1": estadoCivil = "Solteiro";break;
                case "2": estadoCivil = "Casado"; break;
                case "3": estadoCivil = "Viuvo"; break;
            }
            concordo = Request.Form.GetValues("chkConcordo")[0].ToString();
            ViewBag.Nome = nome;
            ViewBag.Email = email;
            ViewBag.Senha = senha;
            ViewBag.Repetir = repetir;
            ViewBag.Lembrete = lembrete;
            ViewBag.Sexo = sexo;
            ViewBag.EstadoCivil = estadoCivil;
            ViewBag.Concordo = concordo;
            return View("NovoLogin");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula04.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string nome, string curso)
        {
            ViewBag.Mensagem = nome + " Bem vindo ao curso de " + curso;
            return View();
        }
        

        #region(atividade)
        public ActionResult MinhaLoja()
        {
            ViewBag.Mensagem = "Minha Loja";
            return View();
        }
        

        #endregion



    }
}
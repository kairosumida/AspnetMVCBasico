using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula06.Controllers
{
    public class AlunosController : Controller
    {
        // GET: Alunos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Notas(double nota1 = 0, double nota2 =0)
        {
            return View();
        }
        public ActionResult Variaveis()
        {
            return View();
        }
    }
}
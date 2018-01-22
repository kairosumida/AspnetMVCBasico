using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula03.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        public ActionResult Index()
        {
            return View();
        }
        public string Soma(double op1, double op2)
        {
            string texto = "<h1>Operação Soma</h1>";
            texto += "<p>Resultado: " + (op1 + op2) + "</p>";
            return texto;
        }
        public string Subtracao(double op1, double op2)
        {
            string texto = "<h1>Operação Subtracao</h1>";
            texto += "<p>Resultado: " + (op1 - op2) + "</p>";
            return texto;
        }
        public string Multiplicacao(double op1, double op2)
        {
            string texto = "<h1>Operação Multiplicacao</h1>";
            texto += "<p>Resultado: " + (op1 * op2) + "</p>";
            return texto;
        }
    }
}
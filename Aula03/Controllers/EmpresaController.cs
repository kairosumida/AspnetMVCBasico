using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula03.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public string Index()
        {
            string texto = "<b>Wincomp Informática Ltda</b><br>";
            texto += "<i>Curso ASP NET MVC</i>";
            return texto;
            
        }
    }
}
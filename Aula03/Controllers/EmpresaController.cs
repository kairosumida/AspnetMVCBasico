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
        public string Endereco()
        {
            string texto = "<b>Wincomp Informática Ltda</b><br>";
            texto += "<i>www.wincomp.com.br</i>";
            return texto;
        }


        //Um exemplo para utilizar o metedo curso
        //No endereço digitar = http://localhost:11111/Empresa/Curso?nome=Kairo&curso=ASP NET MVC 
        public string Curso(string nome, string curso)
        {
            
            string texto = "O aluno " + nome + " esta matriculado no curso " + curso;
            return HttpUtility.HtmlEncode(texto);
        }
    }
}
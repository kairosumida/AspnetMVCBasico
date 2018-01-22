using Aula05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula05.Controllers
{
    public class ProdutosController : Controller
    {
        private Aula05Context db = new Aula05Context();
        // GET: Produtos
        public ActionResult Index()
        {
            return View(db.Produtos.ToList());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aula05.Models;

namespace Aula05.Controllers
{
    public class TreinamentosController : Controller
    {
        private Aula05Context db = new Aula05Context();

        // GET: Treinamentos
        public ActionResult Index()
        {
            return View(db.Treinamentos.ToList());
        }
        
    }
}

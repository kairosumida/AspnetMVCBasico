using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aula09.Models;

namespace Aula09.Controllers
{
    public class CidadesController : Controller
    {
        private Aula09Context db = new Aula09Context();

        // GET: Cidades
        public ActionResult Index(string estado, string cidade)
        {
            var listaEstados = new List<string>();
            var q = from d in db.Cidades
                    orderby d.Estado
                    select d.Estado;
            listaEstados.AddRange(q.Distinct());
            ViewBag.Estado = new SelectList(listaEstados);

            var cidades = from m in db.Cidades select m;

            if (!String.IsNullOrEmpty(cidade))
            {
                cidades = cidades.Where(s => s.Cidades.Contains(cidade));
            }
            if (!string.IsNullOrEmpty(estado))
            {
                cidades = cidades.Where(s => s.Cidades.Contains(cidade));
            }
            
            return View(cidades);
        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

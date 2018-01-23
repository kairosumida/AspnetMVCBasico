using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aula06.Models;

namespace Aula06.Controllers
{
    public class TreinamentosController : Controller
    {
        private Aula06DataContext db = new Aula06DataContext();

        // GET: Treinamentos
        public ActionResult Index()
        {
            return View(db.Treinamentos.ToList());
        }


        // GET: Treinamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Treinamentos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeTreinamento,Inicio,Termino,Preco,Desconto,Local")] Treinamento treinamento)
        {
            if (ModelState.IsValid)
            {
                db.Treinamentos.Add(treinamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(treinamento);
        }

    }
}

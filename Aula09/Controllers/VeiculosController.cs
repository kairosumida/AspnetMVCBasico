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
    public class VeiculosController : Controller
    {
        private Aula09Context db = new Aula09Context();

        // GET: Veiculos
        public ActionResult Index(string marca, string combustivel, string modelo,string precoMin, string precoMax, string estado, string publicar)
        {
            decimal min = 0;
            decimal max = 0;
            var listaMarcas = new List<string>();
            var listaCombustiveis = new List<string>();
            var listaModelo = new List<string>();
            var listaEstado = new List<string>();
            var listaPublicar = new List<string>();
            #region(BuscaMarca)
            var m = from d in db.Veiculos orderby d.Marca.ToString() select d.Marca.ToString();//Busca no banco todas as marcas
            listaMarcas.AddRange(m.Distinct());//Separa as Marcas repetidas e descarta
            ViewBag.Marca = new SelectList(listaMarcas); //Envia para a view com base no nome do dropdown
            #endregion
            #region(BuscaCombustivel)
            var c = from d in db.Veiculos orderby d.Combustivel.ToString() select d.Combustivel.ToString();
            listaCombustiveis.AddRange(c.Distinct());
            ViewBag.Combustivel = new SelectList(listaCombustiveis);
            #endregion
            #region(BuscaModelo)
            var c1 = from d in db.Veiculos orderby d.Modelo select d.Modelo;
            listaModelo.AddRange(c1.Distinct());
            ViewBag.Modelo = new SelectList(listaModelo);
            #endregion
            #region(BuscaEstado)
            var c2 = from d in db.Veiculos orderby d.Estado select d.Estado;
            listaEstado.AddRange(c2.Distinct());
            ViewBag.Estado = new SelectList(listaEstado);
            #endregion
            #region(BuscaPublicar)
            var c3 = from d in db.Veiculos orderby d.Publicar.ToString() select d.Publicar.ToString();
            listaPublicar.AddRange(c3.Distinct());
            ViewBag.Publicar = new SelectList(listaPublicar);
            #endregion
            #region(ValidarPreco)
            try { min = Convert.ToDecimal(precoMin); }catch{}
            try { max = Convert.ToDecimal(precoMax); } catch {}
            #endregion
            var veiculos = from v in db.Veiculos select v;
            if (!String.IsNullOrEmpty(marca))
            {
                veiculos = veiculos.Where(v => v.Marca.ToString() == marca);
            }
            if (!String.IsNullOrEmpty(combustivel))
            {
                veiculos = veiculos.Where(v => v.Combustivel.ToString() == combustivel);
            }
            if (!String.IsNullOrEmpty(modelo))
            {
                veiculos = veiculos.Where(v => v.Modelo == modelo);
            }
            if (!String.IsNullOrEmpty(estado))
            {
                veiculos = veiculos.Where(v => v.Estado == estado);
            }
            if (!String.IsNullOrEmpty(publicar))
            {
                veiculos = veiculos.Where(v => v.Publicar.ToString() == publicar);
            }
            veiculos = veiculos.Where(v => v.Preco > min);
            if (max != 0)
                veiculos = veiculos.Where(v => v.Preco < max);
           
            
            return View(veiculos);
        }

        // GET: Veiculos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculos.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // GET: Veiculos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Marca,Modelo,Observacao,Preco,Estado,Combustivel,Publicar")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                db.Veiculos.Add(veiculo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veiculo);
        }

        // GET: Veiculos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculos.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Marca,Modelo,Observacao,Preco,Estado,Combustivel,Publicar")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veiculo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        // GET: Veiculos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculos.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Veiculo veiculo = db.Veiculos.Find(id);
            db.Veiculos.Remove(veiculo);
            db.SaveChanges();
            return RedirectToAction("Index");
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

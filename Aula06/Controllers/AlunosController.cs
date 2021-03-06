﻿using Aula06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula06.Controllers
{
    public class AlunosController : Controller
    {
        private Aula06DataContext db = new Aula06DataContext();
        // GET: Alunos
        public ActionResult Index()
        {
            return View(db.Alunos.ToList());
        }
        public ActionResult Notas(double nota1 = 0, double nota2 =0)
        {
            return View();
        }
        public ActionResult Variaveis()
        {
            return View();
        }
        public ActionResult Nome()
        {
            return View();
        }
        public ActionResult ListaCursos()
        {
            return View();
        }

        public ActionResult Incluir()
        {
            return View();
        }

        public ActionResult Salvar()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = Request["txtNome"].ToString();
            aluno.Email = Request["txtEmail"].ToString();
            aluno.Senha = Request["txtSenha"].ToString();
            db.Alunos.Add(aluno);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
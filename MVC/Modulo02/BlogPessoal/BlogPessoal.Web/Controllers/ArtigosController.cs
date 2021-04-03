using BlogPessoal.Web.Data.Contexto;
using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BlogPessoal.Web.Controllers
{
    public class ArtigosController : Controller
    {
        private readonly BlogPessoalContexto _ctx = new BlogPessoalContexto();

        // GET: Artigos
        public ActionResult Index()
        {
            return View(_ctx.Artigos.OrderBy(a => a.DataPublicacao).ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artigo artigo)
        {
            if (ModelState.IsValid)
            {
                _ctx.Artigos.Add(artigo);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artigo);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var artigo = _ctx.Artigos.Where(x => x.Id.Equals(id));

            if (artigo == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(artigo);
        }

        [HttpPut]
        public ActionResult Edit(Artigo artigo)
        {
            if (ModelState.IsValid)
            {
                _ctx.Entry(artigo).State = EntityState.Modified;
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artigo);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var artigo = _ctx.Artigos.Where(x => x.Id.Equals(id));

            if (artigo == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(artigo);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var artigo = _ctx.Artigos.Find(id);
            _ctx.Artigos.Remove(artigo);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
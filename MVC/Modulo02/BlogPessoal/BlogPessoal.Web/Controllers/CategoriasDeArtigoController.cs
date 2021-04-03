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
    public class CategoriasDeArtigoController : Controller
    {
        private readonly BlogPessoalContexto _ctx = new BlogPessoalContexto();

        // GET: CategoriasDeArtigo
        public ActionResult Index()
        {
            var categorias = _ctx.CategoriasDeArtigo
                .OrderBy(t => t.Nome).ToList();
            return View(categorias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoriaDeArtigo categoria)
        {
            if (ModelState.IsValid)
            {
                _ctx.CategoriasDeArtigo.Add(categoria);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var categoria = _ctx.CategoriasDeArtigo.Where(x => x.Id == id).FirstOrDefault();

            if (categoria == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(categoria);
        }

        [HttpPost]
        public ActionResult Edit(CategoriaDeArtigo categoria)
        {
            if (ModelState.IsValid)
            {
                _ctx.Entry(categoria).State = EntityState.Modified;
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

#pragma warning disable S4144 // Methods should not have identical implementations
        public ActionResult Delete(int? id)
#pragma warning restore S4144 // Methods should not have identical implementations
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var categoria = _ctx.CategoriasDeArtigo.Where(x => x.Id == id).FirstOrDefault();

            if (categoria == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(categoria);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var categoria = _ctx.CategoriasDeArtigo.Find(id);
            _ctx.CategoriasDeArtigo.Remove(categoria);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
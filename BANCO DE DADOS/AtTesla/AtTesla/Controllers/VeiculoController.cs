using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AtTesla.Models;

namespace AtTesla.Controllers
{
    public class VeiculoController : Controller
    {
        private bdTeslaEntities db = new bdTeslaEntities();

        // GET: Veiculo
        public ActionResult Index()
        {
            var veiculo = db.Veiculo.Include(v => v.Modelo);
            return View(veiculo.ToList());
        }

        // GET: Veiculo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculo.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // GET: Veiculo/Create
        public ActionResult Create()
        {
            ViewBag.MODELID = new SelectList(db.Modelo, "MODELID", "DESCRICAO");
            return View();
        }

        // POST: Veiculo/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VEID,DESCRICAO,VALOR,MODELID")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                db.Veiculo.Add(veiculo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MODELID = new SelectList(db.Modelo, "MODELID", "DESCRICAO", veiculo.MODELID);
            return View(veiculo);
        }

        // GET: Veiculo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculo.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            ViewBag.MODELID = new SelectList(db.Modelo, "MODELID", "DESCRICAO", veiculo.MODELID);
            return View(veiculo);
        }

        // POST: Veiculo/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VEID,DESCRICAO,VALOR,MODELID")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
               
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MODELID = new SelectList(db.Modelo, "MODELID", "DESCRICAO", veiculo.MODELID);
            return View(veiculo);
        }

        // GET: Veiculo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculo.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Veiculo veiculo = db.Veiculo.Find(id);
            db.Veiculo.Remove(veiculo);
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

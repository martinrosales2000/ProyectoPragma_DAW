using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pragma.Models;

namespace Pragma.Controllers
{
    public class loteProductoModelsController : Controller
    {
        private pragmaDBConnection db = new pragmaDBConnection();

        // GET: loteProductoModels
        public ActionResult Index()
        {
            return View(db.loteProductoModels.ToList());
        }

        // GET: loteProductoModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loteProductoModel loteProductoModel = db.loteProductoModels.Find(id);
            if (loteProductoModel == null)
            {
                return HttpNotFound();
            }
            return View(loteProductoModel);
        }

        // GET: loteProductoModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: loteProductoModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_loteProducto,fecha_caducidad,stock")] loteProductoModel loteProductoModel)
        {
            if (ModelState.IsValid)
            {
                db.loteProductoModels.Add(loteProductoModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loteProductoModel);
        }

        // GET: loteProductoModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loteProductoModel loteProductoModel = db.loteProductoModels.Find(id);
            if (loteProductoModel == null)
            {
                return HttpNotFound();
            }
            return View(loteProductoModel);
        }

        // POST: loteProductoModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_loteProducto,fecha_caducidad,stock")] loteProductoModel loteProductoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loteProductoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loteProductoModel);
        }

        // GET: loteProductoModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loteProductoModel loteProductoModel = db.loteProductoModels.Find(id);
            if (loteProductoModel == null)
            {
                return HttpNotFound();
            }
            return View(loteProductoModel);
        }

        // POST: loteProductoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            loteProductoModel loteProductoModel = db.loteProductoModels.Find(id);
            db.loteProductoModels.Remove(loteProductoModel);
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

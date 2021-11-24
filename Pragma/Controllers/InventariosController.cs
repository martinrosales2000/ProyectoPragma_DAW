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
    public class InventariosController : Controller
    {
        private pragmaDBConnection db = new pragmaDBConnection();

        // GET: Inventarios
        public ActionResult Index()
        {
           
            return View(db.Inventario.ToList());
        }

        // GET: Inventarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventariosModel inventariosModel = db.Inventario.Find(id);
            if (inventariosModel == null)
            {
                return HttpNotFound();
            }
            return View(inventariosModel);
        }

        // GET: Inventarios/Create
        public ActionResult Create()
        {
            return View();
        }


        //POST: Inventarios/Create
        //Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse.Para obtener
        //más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.

       [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_inventario,id_loteProducto,cantidad_comprada,cantidad_vendida,id_usuario")] InventariosModel inventariosModel)
        {
            if (ModelState.IsValid)
            {
                db.Inventario.Add(inventariosModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inventariosModel);
        }

        // GET: Inventarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventariosModel inventariosModel = db.Inventario.Find(id);
            if (inventariosModel == null)
            {
                return HttpNotFound();
            }
            return View(inventariosModel);
        }

        // POST: Inventarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_inventario,id_loteProducto,cantidad_comprada,cantidad_vendida,id_usuario")] InventariosModel inventariosModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventariosModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inventariosModel);
        }

        // GET: Inventarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventariosModel inventariosModel = db.Inventario.Find(id);
            if (inventariosModel == null)
            {
                return HttpNotFound();
            }
            return View(inventariosModel);
        }

        // POST: Inventarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InventariosModel inventariosModel = db.Inventario.Find(id);
            db.Inventario.Remove(inventariosModel);
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

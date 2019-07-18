using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using prjrv.Models;

namespace prjrv.Controllers
{
    public class tipoAnimalsController : Controller
    {
        private EjemploDB db = new EjemploDB();

        // GET: tipoAnimals
        public ActionResult Index()
        {
            return View(db.tipoAnimals.ToList());
        }

        // GET: tipoAnimals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipoAnimal tipoAnimal = db.tipoAnimals.Find(id);
            if (tipoAnimal == null)
            {
                return HttpNotFound();
            }
            return View(tipoAnimal);
        }

        // GET: tipoAnimals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tipoAnimals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tipoAnimalId,tipo")] tipoAnimal tipoAnimal)
        {
            if (ModelState.IsValid)
            {
                db.tipoAnimals.Add(tipoAnimal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoAnimal);
        }

        // GET: tipoAnimals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipoAnimal tipoAnimal = db.tipoAnimals.Find(id);
            if (tipoAnimal == null)
            {
                return HttpNotFound();
            }
            return View(tipoAnimal);
        }

        // POST: tipoAnimals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tipoAnimalId,tipo")] tipoAnimal tipoAnimal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoAnimal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoAnimal);
        }

        // GET: tipoAnimals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipoAnimal tipoAnimal = db.tipoAnimals.Find(id);
            if (tipoAnimal == null)
            {
                return HttpNotFound();
            }
            return View(tipoAnimal);
        }

        // POST: tipoAnimals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tipoAnimal tipoAnimal = db.tipoAnimals.Find(id);
            db.tipoAnimals.Remove(tipoAnimal);
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

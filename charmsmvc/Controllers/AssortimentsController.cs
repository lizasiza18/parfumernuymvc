using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using charmsmvc.Models;

namespace charmsmvc.Controllers
{
    public class AssortimentsController : Controller
    {
        private parfumernuyEntities db = new parfumernuyEntities();

        // GET: Assortiments
        public ActionResult Index()
        {
            return View(db.Assortiments.ToList());
        }

        // GET: Assortiments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assortiment assortiment = db.Assortiments.Find(id);
            if (assortiment == null)
            {
                return HttpNotFound();
            }
            return View(assortiment);
        }

        // GET: Assortiments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assortiments/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,название,цена_,объем,производитель_,страна_,дата_призводства,артикул,количество")] Assortiment assortiment)
        {
            if (ModelState.IsValid)
            {
                db.Assortiments.Add(assortiment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assortiment);
        }

        // GET: Assortiments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assortiment assortiment = db.Assortiments.Find(id);
            if (assortiment == null)
            {
                return HttpNotFound();
            }
            return View(assortiment);
        }

        // POST: Assortiments/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,название,цена_,объем,производитель_,страна_,дата_призводства,артикул,количество")] Assortiment assortiment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assortiment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assortiment);
        }

        // GET: Assortiments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assortiment assortiment = db.Assortiments.Find(id);
            if (assortiment == null)
            {
                return HttpNotFound();
            }
            return View(assortiment);
        }

        // POST: Assortiments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assortiment assortiment = db.Assortiments.Find(id);
            db.Assortiments.Remove(assortiment);
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

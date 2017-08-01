using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class oglasiController : Controller
    {
        oglasiContext2 db = new oglasiContext2();

        public ActionResult Index()
        {
            return View(db.oglas.ToList());
        }
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ogla oglasi)
        {
            if(ModelState.IsValid)
            {
                db.oglas.Add(oglasi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oglasi);
        }
        [Authorize]
        public ActionResult Edit(int? id)
        {
            ogla oglasi = db.oglas.Find(id);
            if (oglasi == null)
            {
                return HttpNotFound();
            }
            return View(oglasi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="OglasID,start,cilj,cas,strosek,opis,st_oseb")] ogla oglasi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oglasi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oglasi);
        }
    }
}
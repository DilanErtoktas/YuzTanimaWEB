using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facerecognition.Models.Entity;

namespace Facerecognition.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        DbFaceRecEntities db = new DbFaceRecEntities();
        public ActionResult Index()
        {
            var degerler = db.Personel.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult PersonelEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(Personel p)
        {
            db.Personel.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelSil(int id)
        {
            var personel = db.Personel.Find(id);
            db.Personel.Remove(personel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
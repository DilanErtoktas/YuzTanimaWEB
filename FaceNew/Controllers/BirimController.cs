using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;

namespace FaceNew.Controllers
{
    public class BirimController : Controller
    {
        facerecEntities db = new facerecEntities();
        public ActionResult Index()
        {
            var degerler = db.personel_birim.ToList();
            return View(degerler);
     
        }



        [HttpGet]
        public ActionResult BirimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BirimEkle(personel_birim b)
        {
            db.personel_birim.Add(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BirimGetir(int id)
        {
            var brm = db.personel_birim.Find(id);
            return View("BirimGetir", brm);
        }

        public ActionResult BirimGuncelle(personel_birim b)
        {
            var brm = db.personel_birim.Find(b.birim_ID);
            brm.birimi = b.birimi;
            
            db.SaveChanges();
            return RedirectToAction("Index");

        }


    }

}

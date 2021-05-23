using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;

namespace FaceNew.Controllers
{
    public class KameralarController : Controller
    {
        // GET: Kameralar
        facerecEntities db = new facerecEntities();
        public ActionResult Index()
        {
            var degerler = db.kamera.ToList();
            return View(degerler);
        }

        public ActionResult KameraSil(int id)
        {
            var kamera = db.kamera.Find(id);
            db.kamera.Remove(kamera);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult KameraGetir(int id)
        {
            var kmr = db.kamera.Find(id);
            return View("KameraGetir", kmr);
        }

        public ActionResult KameraGuncelle(kamera k)
        {
            var kmr = db.kamera.Find(k.kamera_IP);
            kmr.personel_ID = k.personel_ID;
            kmr.firma_ID = k.firma_ID;
            kmr.kamera_konum_isimlendirme = k.kamera_konum_isimlendirme;
            
            db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
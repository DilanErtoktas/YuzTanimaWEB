using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;
namespace FaceNew.Controllers
{
    public class FirmalarController : Controller
    {
        // GET: Firmalar
        facerecEntities db = new facerecEntities();
        public ActionResult Index()
        {
            var degerler = db.firma.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult FirmaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FirmaEkle(firma f)
        {
            db.firma.Add(f);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FirmaGetir(int id)
        {
            var frm = db.firma.Find(id);
            return View("FirmaGetir", frm);
        }

        public ActionResult FirmaGuncelle(firma f)
        {
            var frm = db.firma.Find(f.firma_ID);
            frm.firma_ismi= f.firma_ismi;
            frm.firma_tel = f.firma_tel;
            frm.firma_mail = f.firma_mail;

            db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
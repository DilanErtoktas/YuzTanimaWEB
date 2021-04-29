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

        public ActionResult PersonelGetir(int id)
        {
            var prss = db.Personel.Find(id);
            return View("PersonelGetir", prss);
        }

        public ActionResult PersonelGuncelle(Personel p)
        {
            var prss = db.Personel.Find(p.personelid);
            prss.kullaniciadi = p.kullaniciadi;
            prss.kullanicisifre = p.kullanicisifre;
            prss.kimlikno = p.kimlikno;
            prss.firmaid = p.firmaid;
            prss.personeladi = p.personeladi;
            prss.personelsoyadi = p.personelsoyadi;
            prss.personelmail = p.personelmail;
            prss.adres = p.adres;
            prss.telefon = p.telefon;
            prss.birimi = p.birimi;
            prss.giriszamani = p.giriszamani;
            prss.cikiszamani = p.cikiszamani;
            prss.ziyaretsaati = p.ziyaretsaati;
            prss.maas = p.maas;
            prss.mesai = p.mesai;
            prss.odaid = p.odaid;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
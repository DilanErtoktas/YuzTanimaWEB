using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;

namespace FaceNew.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        facerecEntities db = new facerecEntities();
        public ActionResult Index()
        {
            var degerler = db.personel.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult PersonelEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(personel p)
        {
            db.personel.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelSil(int id)
        {
            var personel = db.personel.Find(id);
            db.personel.Remove(personel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelGetir(int id)
        {
            var prss = db.personel.Find(id);
            return View("PersonelGetir", prss);
        }

        public ActionResult PersonelGuncelle(personel p)
        {
            var prss = db.personel.Find(p.personel_ID);
            prss.kullanıcı_ADI = p.kullanıcı_ADI;
            prss.kullanıcı_sifre = p.kullanıcı_sifre;
            prss.kimlik_numarası = p.kimlik_numarası;
            prss.firma_ID = p.firma_ID;
            prss.Padsoyad = p.Padsoyad;
            prss.mail = p.mail;
            prss.adres = p.adres;
            prss.telefon = p.telefon;
            prss.birim_ID = p.birim_ID;
            prss.ziyaret_saatleri = p.ziyaret_saatleri;
            prss.maas = p.maas;
            prss.mesai = p.mesai;
            prss.oda_ID = p.oda_ID;
            prss.personel_resim = p.personel_resim;
            prss.personel_anahtar = p.personel_anahtar;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
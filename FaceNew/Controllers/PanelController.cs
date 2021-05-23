using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;

namespace FaceNew.Controllers
{
    public class PanelController : Controller
    {
        // GET: Panel
        facerecEntities db = new facerecEntities();
        [Authorize]
        public ActionResult Index()
        {

            var kullaniciadii = (string)Session["KullaniciAdi"];
            var degerler = db.personel.FirstOrDefault(z => z.kullanıcı_ADI == kullaniciadii);
            return View(degerler);
        }

        [HttpPost]
        public ActionResult Index2(personel p)
        {
            var kullanici = (string)Session["KullaniciAdi"];
            var kullanicik = db.personel.FirstOrDefault(x => x.kullanıcı_ADI == kullanici);

            kullanicik.kullanıcı_sifre = p.kullanıcı_sifre;
            kullanicik.Padsoyad = p.Padsoyad;
            kullanicik.mail = p.mail;
            kullanicik.adres = p.adres;
            kullanicik.telefon = p.telefon;

            db.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
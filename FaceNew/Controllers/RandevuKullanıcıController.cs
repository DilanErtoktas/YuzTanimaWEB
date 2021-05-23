using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;

namespace FaceNew.Controllers
{
    public class RandevuKullanıcıController : Controller
    {
        // GET: Personel
        facerecEntities db = new facerecEntities();
        public ActionResult Index()
        {
            var degerler = db.ziyaretci.ToList();
            return View(degerler);
        }
        
       
       
        public ActionResult ZiyaretciReddet(int id)
        {
            var ziyaretci = db.ziyaretci.Find(id);
            db.ziyaretci.Remove(ziyaretci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ZiyaretciGetir(int id)
        {
            var zyr = db.ziyaretci.Find(id);
            return View("ZiyaretciGetir", zyr);
        }

        public ActionResult ZiyaretciOnayla(ziyaretci z)
        {
            var zyr = db.ziyaretci.Find(z.ziyaretci_ID);
            zyr.ziyaret_durum = true;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
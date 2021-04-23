using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facerecognition.Models.Entity;
namespace Facerecognition.Controllers
{
    public class FirmalarController : Controller
    {
        // GET: Firmalar
        DbFaceRecEntities db = new DbFaceRecEntities();
        public ActionResult Index()
        {
            var degerler = db.Firma.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult FirmaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FirmaEkle(Firma f)
        {
            db.Firma.Add(f);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
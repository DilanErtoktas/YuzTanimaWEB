using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facerecognition.Models.Entity;

namespace Facerecognition.Controllers
{
    public class KameralarController : Controller
    {
        // GET: Kameralar
        DbFaceRecEntities db = new DbFaceRecEntities();
        public ActionResult Index()
        {
            var degerler = db.Kamera.ToList();
            return View(degerler);
        }

        public ActionResult KameraSil(int id)
        {
            var kamera = db.Kamera.Find(id);
            db.Kamera.Remove(kamera);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
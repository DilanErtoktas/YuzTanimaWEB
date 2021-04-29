using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facerecognition.Models.Entity;
using Facerecognition.Models;
namespace Facerecognition.Controllers
{
    public class ZiyaretciFormController : Controller
    {
        
        // GET: ZiyaretciForm
        DbFaceRecEntities db = new DbFaceRecEntities();
        public ActionResult Index()
        {
            var degerler = db.Ziyaretci.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Ziyaretci z)
        {
            db.Ziyaretci.Add(z);
            db.SaveChanges();
            return RedirectToAction("Create");

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;
using FaceNew.Models;
namespace FaceNew.Controllers
{
    public class ZiyaretciFormController : Controller
    {

        // GET: ZiyaretciForm
        facerecEntities db = new facerecEntities();
        public ActionResult Index()
        {
            var degerler = db.ziyaretci.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ziyaretci z)
        {
            db.ziyaretci.Add(z);
            db.SaveChanges();
            return RedirectToAction("Create");

        }

    }

}
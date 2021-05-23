using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;
namespace FaceNew.Controllers
{
    public class ZiyaretciController : Controller
    {
        // GET: Ziyaretci
        facerecEntities db = new facerecEntities();
        public ActionResult Index()
        {
            var degerler = db.ziyaretci.ToList();
            return View(degerler);
        }
    }
}
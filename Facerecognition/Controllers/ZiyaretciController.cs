using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facerecognition.Models.Entity;
namespace Facerecognition.Controllers
{
    public class ZiyaretciController : Controller
    {
        // GET: Ziyaretci
        DbFaceRecEntities db = new DbFaceRecEntities();
        public ActionResult Index()
        {
            var degerler = db.Ziyaretci.ToList();
            return View(degerler);
        }
    }
}
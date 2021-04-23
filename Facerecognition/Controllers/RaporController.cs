using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facerecognition.Models.Entity;

namespace Facerecognition.Controllers
{
    public class RaporController : Controller
    {
        DbFaceRecEntities db = new DbFaceRecEntities();
        public ActionResult Index()
        {
            var degerler = db.Personel.ToList();
            return View(degerler);
        }
    }
}
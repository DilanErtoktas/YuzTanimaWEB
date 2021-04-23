using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facerecognition.Models.Entity;
using System.Web.Security;

namespace Facerecognition.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DbFaceRecEntities db = new DbFaceRecEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Personel p)
        {
            var bilgiler = db.Personel.FirstOrDefault(x => x.kullaniciadi==p.kullaniciadi && x.kullanicisifre == p.kullanicisifre);
            if(bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciadi, false);
                return RedirectToAction("Index", "Panel");
            }
            else
            {
                return View();
            }
          
        }
    }
}
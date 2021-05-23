using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaceNew.Models.Entity;
using System.Web.Security;

namespace FaceNew.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        facerecEntities db = new facerecEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(personel p)
        {
            var bilgiler = db.personel.FirstOrDefault(x => x.kullanıcı_ADI == p.kullanıcı_ADI && x.kullanıcı_sifre == p.kullanıcı_sifre);
            if (bilgiler != null)
            {

                FormsAuthentication.SetAuthCookie(bilgiler.kullanıcı_ADI, false);
                Session["KullaniciAdi"] = bilgiler.kullanıcı_ADI.ToString();
                return RedirectToAction("Index", "Panel");
            }
            else
            {
                return View();
            }

        }
    }
}
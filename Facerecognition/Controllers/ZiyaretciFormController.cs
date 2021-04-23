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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            
            
            
            return View();
        }

    }
}
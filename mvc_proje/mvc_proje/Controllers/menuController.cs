using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_proje.Models.entity;

namespace mvc_proje.Controllers
{
    public class menuController : Controller
    {
        //
        // GET: /menu/
        mvcEntities db = new mvcEntities();
        public ActionResult Index()
        {
            var anasayfa = db.anasayfa.ToList();
            return View(anasayfa);
        }

    }
}

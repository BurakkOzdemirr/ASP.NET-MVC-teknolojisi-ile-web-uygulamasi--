using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_proje.Models.entity;

namespace mvc_proje.Controllers
{
    public class bilgiController : Controller
    {
        //
        // GET: /bilgi/
        mvcEntities db = new mvcEntities();
        public ActionResult Index()
        {
            var g = db.bilgi.ToList();
            return View(g);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Stok.Models.Entity;

namespace Mvc_Stok.Controllers
{
    public class SatisController : Controller
    {
        MvcDbStokEntities db = new MvcDbStokEntities();
         public ActionResult Index()
        {
            return View();
        }
         [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p1)
        {
            db.TBLSATISLAR.Add(p1);
            db.SaveChanges();
            return View("Index");
        }
    }
}
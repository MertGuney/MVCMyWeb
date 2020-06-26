using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MJG.Models.Entity;
using MJG.Models.IEClass;
namespace MJG.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        mertgune_AdminEntities db = new mertgune_AdminEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.tblHakkimda.ToList();
            cs.Deger2 = db.tblHizmetler.ToList();
            cs.Deger3 = db.tblDeneyim.ToList();
            return View(cs);
        }
    }
}
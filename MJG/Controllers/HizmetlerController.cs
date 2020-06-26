using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MJG.Models.Entity;
using MJG.Models.IEClass;
namespace MJG.Controllers
{
    public class HizmetlerController : Controller
    {
        // GET: Hizmetler
        mertgune_AdminEntities db = new mertgune_AdminEntities();
        [Authorize]
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger2 = db.tblHizmetler.ToList();
            return View(cs);
        }
        public ActionResult VeriGetir(int id)
        {
            var veriler = db.tblHizmetler.Find(id);
            return View("VeriGetir", veriler);
        }
        public ActionResult Guncelle(tblHizmetler p)
        {
            var degerler = db.tblHizmetler.Find(p.ID);
            degerler.baslik = p.baslik;
            degerler.aciklama = p.aciklama;
            degerler.ico = p.ico;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniHizmet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniHizmet(tblHizmetler p)
        {
            db.tblHizmetler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
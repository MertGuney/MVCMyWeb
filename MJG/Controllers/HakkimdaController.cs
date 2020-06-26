using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MJG.Models.Entity;
using MJG.Models.IEClass;

namespace MJG.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        mertgune_AdminEntities db = new mertgune_AdminEntities();
        [Authorize]
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.tblHakkimda.ToList();
            return View(cs);
        }
        public ActionResult VeriGetir(int id)
        {
            var veriler = db.tblHakkimda.Find(id);
            return View("VeriGetir", veriler);
        }
        public ActionResult Guncelle(tblHakkimda p)
        {
            var degerler = db.tblHakkimda.Find(p.ID);
            degerler.aciklama = p.aciklama;
            degerler.bölge = p.bölge;
            degerler.yas = p.yas;
            degerler.mail = p.mail;
            degerler.egitim = p.egitim;
            degerler.telefon = p.telefon;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
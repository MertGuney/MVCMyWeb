using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MJG.Models.Entity;
using MJG.Models.IEClass;
namespace MJG.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        mertgune_AdminEntities db = new mertgune_AdminEntities();
        [Authorize]
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger3 = db.tblDeneyim.ToList();
            return View(cs);
        }
        public ActionResult VeriGetir(int id)
        {
            var veriler = db.tblDeneyim.Find(id);
            return View("VeriGetir", veriler);
        }
        public ActionResult Guncelle(tblDeneyim p)
        {
            var degerler = db.tblDeneyim.Find(p.ID);
            degerler.egitimTarih = p.egitimTarih;
            degerler.egitimBaslik = p.egitimBaslik;
            degerler.egitimAciklama = p.egitimAciklama;
            degerler.hizmetTarih = p.hizmetTarih;
            degerler.hizmetBaslik = p.hizmetBaslik;
            degerler.hizmetAciklama = p.hizmetAciklama;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniDeneyim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniDeneyim(tblDeneyim p)
        {
            db.tblDeneyim.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
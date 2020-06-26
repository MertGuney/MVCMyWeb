using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MJG.Models.Entity;
using System.Web.Security;

namespace MJG.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        mertgune_AdminEntities db = new mertgune_AdminEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tblKullanici p)
        {
            var bilgiler = db.tblKullanici.FirstOrDefault(x => x.kullaniciAdi == p.kullaniciAdi && x.sifre == p.sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciAdi, false);
                return RedirectToAction("Index", "Hakkimda");
            }
            else
            {
                return View();
            }
        }
    }
}
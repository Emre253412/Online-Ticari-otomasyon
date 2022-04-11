using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ONLİNETİCARİOTOMASYON.Models.Sınıflar;

namespace ONLİNETİCARİOTOMASYON.Controllers
{
    public class kategoriController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.kategoris.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        public ActionResult KategoriEkle(Kategori k)
        {
            c.kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriSil(int id)
        {
            var ktg = c.kategoris.Find(id);
            c.kategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }
        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = c.kategoris.Find(k.kategoriid);
            ktgr.kategorıad = k.kategorıad;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
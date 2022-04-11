using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ONLİNETİCARİOTOMASYON.Models.Sınıflar;

namespace ONLİNETİCARİOTOMASYON.Controllers
{
    public class DepartmanController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Departmens.Where(x=> x.durum==true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            c.Departmens.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanSil(int id)
        {
            var dpr = c.Departmens.Find(id);
            dpr.durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanGetir(int id)
        {
            var dep = c.Departmens.Find(id);
            return View("DepartmanGetir", dep);
        }
        public ActionResult DepartmanGuncelle(Departman d)
        {
            var depa = c.Departmens.Find(d.departmanid);
            depa.departmanad = d.departmanad;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanDetay(int id)
        {
            var degerler = c.personels.Where(x => x.departmanid == id).ToList();
            var dpt = c.Departmens.Where(x => x.departmanid == id).Select(y => y.departmanad).FirstOrDefault();
            ViewBag.d = dpt;
            return View(degerler);
        }
    }
}
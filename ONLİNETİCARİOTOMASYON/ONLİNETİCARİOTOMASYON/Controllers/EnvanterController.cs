using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ONLİNETİCARİOTOMASYON.Models.Sınıflar;
namespace ONLİNETİCARİOTOMASYON.Controllers
{
    public class EnvanterController : Controller
    {

        Context c = new Context();
        public ActionResult Index()
        {
            var envanter = c.envanters.ToList();
            return View(envanter);
        }
        [HttpGet]
        public ActionResult YeniEnvanter()
        {
            List<SelectListItem> deger1 = (from x in c.ürünlers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.ürünad,
                                               Value = x.ürünid.ToString()

                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult YeniEnvanter(Envanter u)
        {
            c.envanters.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EnvanterSil(int id)
        {
            var env = c.envanters.Find(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EnvanterGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.ürünlers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.ürünad,
                                               Value = x.ürünid.ToString()

                                           }).ToList();
            ViewBag.dgr1 = deger1;
            var env1 = c.envanters.Find(id);
            return View("EnvanterGetir", env1);
        }
        public ActionResult EnvanterGuncelle(Envanter n)
        {
            var urnn = c.envanters.Find(n.envanterid);
            urnn.alınanadet =n.alınanadet;
            urnn.alisfiyat = n.alisfiyat;
            urnn.arızalıürünsayısı = n.arızalıürünsayısı;
            urnn.Ürünlerid= n.Ürünlerid;
            urnn.serikod = n.serikod;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
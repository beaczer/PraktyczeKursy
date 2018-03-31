using PraktyczeKursy.DAL;
using PraktyczeKursy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PraktyczeKursy.Controllers
{
    public class HomeController : Controller
    {
        private KursyContext db = new KursyContext();
        public ActionResult Index()
        {
            var listaKategori = db.Kategorie.ToList();

            return View();
        }
        public ActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }
    }
}
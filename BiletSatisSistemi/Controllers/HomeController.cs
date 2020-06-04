using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BiletSatisSistemi.Veri;
using BiletSatisSistemi.Models;

namespace BiletSatisSistemi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Events()
        {
            List<Filmler> Filim = new List<Filmler>()
            {
            new Filmler{FilimId=1,FilimAdi="sdsd",Yonetmen="Bilgisayar ",Oyuncular="fdgfdgdf",Ozet="cxcvxcvxvxcvxc c",Sure=45,Resim="sinema1.png",Vizyontrh="21.10.2019",Katagori="dfdsfsd"},

             };
            return View(Filim.ToList());

        }
        public ActionResult Info()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
 
    }
}
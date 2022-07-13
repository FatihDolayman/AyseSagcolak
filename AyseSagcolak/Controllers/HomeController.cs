using AyseSagcolak.Data;
using AyseSagcolak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AyseSagcolak.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Subscriber subscriber)
        {

            try
            {
                //insert işlemi.
                subscriber.CreatedAt = DateTime.Now;
                db.Subscribers.Add(subscriber);
                db.SaveChanges();
                ViewBag.Success = true;
                ViewBag.Message = "Bilgileriniz başarılı bir şekilde kaydedilmiştir. En kısa sürede" +
             "size dönüş yapacağız.";
            }
            catch (Exception ex)
            {
                var test = ex;
                ViewBag.Success = false;
                ViewBag.Message = "Başarısız!";
            }


            return View();
        }

        [Authorize()]
        public ActionResult Subscribers()
        {
            var subs = db.Subscribers.OrderByDescending(a => a.CreatedAt).ToList();
            
            return View(subs);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
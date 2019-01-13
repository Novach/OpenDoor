using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneMarket.Models;

namespace PhoneMarket.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext PhoneContext = new PhoneContext();


        public ActionResult Index()
        {
            //извлекаем данные из таблицы Phones
            IEnumerable<Phone> phones = PhoneContext.Phones;

            //записываем phones в динамическое свойство ViewBag
            ViewBag.Phones = phones;

            return View();
        }

        [HttpGet]//переход по ссылке
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]//при пост запросе
        public string Buy(Purchase purchase)
        {
            purchase.DataTime = DateTime.Now;
            PhoneContext.Purchases.Add(purchase);
            PhoneContext.SaveChanges():
            return $"Уважаемый,{purchase.FIO}, c вами скоро свяжутся";
        }
    }
}

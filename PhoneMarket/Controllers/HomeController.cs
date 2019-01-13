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

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SanwichCalc.DataAccess;
using SanwichCalc.Models.Home;

namespace SanwichCalc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var entities = new SandwichDBEntities();
            var sandwiches = entities.Sandwiches.Select(s => s).OrderBy(x => x.SandwichName);
            var currencies = entities.Currency.Select(c => c).OrderBy(x => x.CurrencyName);
            var sandwichList = new SelectList(sandwiches, "SandwichModifier", "SandwichName");
            var currencyList = new SelectList(currencies, "CurrencyModifier", "CurrencyName");
            var model = new IndexViewModel
            {
                Sandwiches = sandwichList,
                Currencies = currencyList
            };

            return View(model);
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
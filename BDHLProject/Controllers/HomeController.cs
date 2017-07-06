using BDHLProject.Models;
using BDHLProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BDHLProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Statistics(SearchModel model)
        {
            ViewBag.Message = "Your application description page.";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Facts201516()
        {
            return View();
        }
        public ActionResult Facts201415()
        {
            return View();
        }

        public ActionResult Facts201314()
        {
            return View();
        }

        public ActionResult Facts201213()
        {
            return View();
        }

        public ActionResult StatisticsGridPartial(string YearDropdown, string TypeDropdown)
        {
            SearchModel model = new SearchModel();
            model.StatisticsType = TypeDropdown;
            model.DBYear = YearDropdown;
            model.PlayersSixteenSeventeen = _2016_17PlayersRepository.Get201617Players().OrderByDescending(x => x.Points).ToList();
            model.PPPlayersSixteenSeventeen = _2016_17PlayersRepository.Get201617PPPlayers().OrderByDescending(x => x.Points).ToList();
            return View("_StatisticsGrid", model);
        }
    }
}
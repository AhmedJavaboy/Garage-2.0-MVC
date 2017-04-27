using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GarageLux.DataAccessLayer;

namespace GarageLux.Controllers
{
    public class HomeController : Controller
    {
        IncheckedVehicleContext db=new IncheckedVehicleContext();
        public ActionResult Index(string searchTerm=null)
        {
            var model = from r in db.Vehicles
                        where r.Model==null||r.Model.StartsWith(searchTerm)
                        select r;
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
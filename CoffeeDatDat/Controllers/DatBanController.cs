using CoffeeDatDat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeDatDat.Controllers
{
    public class DatBanController : Controller
    {
        Data_Coffee db = new Data_Coffee();
        // GET: DatBan
        public ActionResult Index()
        {
            var model = db.DATBANs.SqlQuery("ThongKeBan");
            return View(model);
        }
    }
}
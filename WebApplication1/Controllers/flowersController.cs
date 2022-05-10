using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Views.flowers;

namespace WebApplication1.Controllers
{
    public class flowersController : Controller
    {
        // GET: flowers
        public ActionResult Index()
        {
            List<flowersModel> flowers = new List<flowersModel>();

            flowers.Add(new flowersModel(1, "Rose", "june", "red", 30));
            flowers.Add(new flowersModel(2, "Lilija", "may", "yelow", 40));
            flowers.Add(new flowersModel(3, "Erimurus", "august", "pink", 80));
            flowers.Add(new flowersModel(4, "Esholcija", "april", "orange", 20));
            
            return View("index", flowers);
        }

    }
}
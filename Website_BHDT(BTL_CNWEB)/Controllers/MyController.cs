using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_BHDT_BTL_CNWEB_.Models.Functions;

namespace Website_BHDT_BTL_CNWEB_.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            var model = new SanPhamF().SanPhams.ToList();
            return View(model);
        }
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult SingleProduct()
        {
            return View();
        }

    }
}
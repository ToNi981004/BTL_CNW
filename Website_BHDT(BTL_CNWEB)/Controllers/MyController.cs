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
            var model = new SanPhamF().SanPhams.ToList();
            return View(model);
        }
        public ActionResult Cart()
        {
            var model = new SanPhamF().DSSP_KH().ToList();
            return View(model);
        }

        public ActionResult SingleProduct(string ID)
        {

            if (ID == null)
            {
               
                ID = "SP02";
                var model = new SanPhamF().FindEntity(ID);
                return View(model);
            }
            else
            {
                
                var model = new SanPhamF().FindEntity(ID);
                return View(model);
            }   
        }
        public ActionResult Information()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }
       

    }
}
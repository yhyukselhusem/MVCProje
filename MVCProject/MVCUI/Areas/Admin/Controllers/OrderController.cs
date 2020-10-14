using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/OrderController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListOrder()
        {
            return View();
        }
    }
}
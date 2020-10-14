using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class AppUserController : Controller
    {
        AppUserService _appUserService = new AppUserService();
        // GET: Admin/AppUser
        public ActionResult Index()
        {
            var revenue = _appUserService.AppUserRevenue();
            return View(_appUserService.GetAll());
        }
        public ActionResult AddUser()
        {
            return View();
        }
    }
}
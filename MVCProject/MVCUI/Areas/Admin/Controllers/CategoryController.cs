using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService _categoryService = new CategoryService();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var revenue = _categoryService.CategoryRevenue();
            return View(_categoryService.GetAll());
        }
        public ActionResult AddCategory()
        {
            return View();
        }
    }
}
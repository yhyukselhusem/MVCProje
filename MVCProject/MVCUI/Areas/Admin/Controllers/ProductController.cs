using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        ProductService _productService = new ProductService();
        public ActionResult Index()
        {
            var revenue = _productService.ProductRevenue();
            return View(_productService.GetAll());
        }

        public ActionResult AddProduct()
        {
            return View();
        }
    }
}
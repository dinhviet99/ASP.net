using Cart.Demo.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cart.Demo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}
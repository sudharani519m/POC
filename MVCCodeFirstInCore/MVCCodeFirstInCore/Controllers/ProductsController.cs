using Microsoft.AspNetCore.Mvc;
using MVCCodeFirstInCore.Services;

namespace MVCCodeFirstInCore.Controllers
{
    [Route("ProductInfo")]
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }
        [HttpGet("/ProductInfo/Index")]
        public IActionResult Index()
        {
            var pList = _service.GetAllProducts();
            return View(pList);
        }

        [HttpGet("/ProductInfo/Info")]
        public IActionResult Info()
        {
            ViewData["Msg"] = "Hello.This message is from view data";
            ViewBag.abc = "Hello via viewbag";
            TempData["notice"] = "we can access even in another controller";
            return RedirectToAction("Show");
        }

        public IActionResult Show()
        {
            var notice = TempData["notice"];
            return View();
        }
    }
}

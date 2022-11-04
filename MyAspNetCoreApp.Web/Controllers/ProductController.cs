using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return RedirectToAction("Index","Product"); //ındexe yönlendirdi böyle bir  istek gelirse Indexe gönder
           // return View();
        }
        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }
        public IActionResult JsonResult()
        {
            return Json(new {Id = 1,name="Kupa Bardak",price=100});
        }
        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Product", new { id = id }); 
        }
        public IActionResult JsonResultParametre(int id)
        {
            return Json(new
            { Id = 1, name = "Kupa Bardak", price = 100 });
        }
        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
     
    }
}

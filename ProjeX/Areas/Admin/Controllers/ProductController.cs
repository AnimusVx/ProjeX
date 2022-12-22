using Microsoft.AspNetCore.Mvc;
using ProjeXModels;

namespace ProjeXWebUI.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product product)  //POST
        {
            return RedirectToPage("Index");
        }
    }
}

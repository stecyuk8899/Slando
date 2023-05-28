using Microsoft.AspNetCore.Mvc;
using Slando.Models;
using System.Diagnostics;
using WorkData.DB;

namespace Slando_Olx.Controllers
{
    public class HomeController : Controller
    {
        private readonly SlandoDbContext context;
        public HomeController(SlandoDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }

        public IActionResult AddInform(int id)
        {
            var item = context.Products.Find(id);

            if (item == null)
                return NotFound();

            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var item = context.Products.FirstOrDefault(x => x.Id == id);

            if (item == null)
                return NotFound();

            context.Products.Remove(item);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
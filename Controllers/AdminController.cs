using Microsoft.AspNetCore.Mvc;
using TechnicalStore.DataBaseConnection.db.connections;
using TechnicalStore.DataBaseConnection.Factory;
using TechnicalStore.Models;

namespace TechnicalStore.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {

        }
        public IActionResult Add()
        {
            var AllProduct = Factory.GetAllProduct(DatabaseConnection.GetAllProduct());
            ViewBag.allproduct = AllProduct;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            Factory.AddProduct(product);
            return Redirect("/Admin/Add");
        }
    }
}

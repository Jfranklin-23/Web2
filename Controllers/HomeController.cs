using Microsoft.AspNetCore.Mvc;
using Web2.Model;

namespace Web2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var listOfProduct = new List<Product>();

            listOfProduct.Add(new Product(10001, "Moby", "Yellow Sweet", "07a", 123, "07-06-2024"));
            listOfProduct.Add(new Product(10002, "Cranklings", "Sour", "07b", 456, "07-07-2024"));
            listOfProduct.Add(new Product(10003, "Clover", "Cheesy", "07c", 789, "07-08-2024"));
            listOfProduct.Add(new Product(10004, "Piatoz", "Cheesy", "07d", 101, "07-09-2024"));
            listOfProduct.Add(new Product(10005, "Mang Juan", "Sour", "07e", 112, "07-10-2024"));
            listOfProduct.Add(new Product(10006, "Oishi", "Salty", "07f", 131, "05-11-2024"));

            return View(listOfProduct);
        }
    }
}
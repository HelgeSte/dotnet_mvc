using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //public string Index()
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Sif", Age = 2 };

            return View(doggo);
            //return "This is the index page!";
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}

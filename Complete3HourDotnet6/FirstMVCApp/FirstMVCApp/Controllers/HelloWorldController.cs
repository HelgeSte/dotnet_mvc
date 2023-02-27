using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        
        
        //public string Index()
        public IActionResult Index()
        {
            
            return View(dogs);
            //return "This is the index page!";
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }
    }
}

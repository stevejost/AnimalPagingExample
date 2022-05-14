using Microsoft.AspNetCore.Mvc;
using SimplePagingExample.Models;

namespace SimplePagingExample.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index(int currentPage = 1, int numItems = 3)
        {
            var model = new AnimalIndexViewModel();
            var animalRepo = new AnimalRepository();
            var pageSize = numItems;

            model.PagingModel = new AnimalPagingModel()
            {
                CurrentPage = currentPage,
                ItemsPerPage = numItems,
                TotalItems = animalRepo.GetTotalAnimals(),
                NumPages = (int)Math.Ceiling((double)animalRepo.GetTotalAnimals() / pageSize)
            };
            
            model.Animals = animalRepo.GetAnimals(currentPage, pageSize);

            return View(model);
        }
    }
}

using CarInfoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarInfoApp.Controllers
{
    public class CarController : Controller
    {

        private readonly CarService _carService;
        public CarController(CarService carService)
        {
            _carService = carService;
        }
        public async Task <IActionResult> Index()
        {
            var makes = await _carService.GetAllMakes();
            return View(makes);
        }
    }
}

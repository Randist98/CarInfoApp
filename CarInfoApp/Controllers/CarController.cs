using Microsoft.AspNetCore.Mvc;
using CarInfoApp.Service;

public class CarController : Controller
{
    private readonly CarService _carService;

    public CarController(CarService carService)
    {
        _carService = carService;
    }

    public async Task<IActionResult> Index()
    {
        var makes = await _carService.GetAllMakes();
        return View(makes);
    }

    [HttpGet]
    public async Task<IActionResult> VehicleTypes(int makeId)
    {
        var types = await _carService.GetVehicleTypes(makeId);
        return Json(types);
    }

    [HttpGet]
    public async Task<IActionResult> Models(int makeId, int year)
    {
        var models = await _carService.GetModels(makeId, year);
        return Json(models);
    }
}

using Business.Abstract;
using Entity.Concerete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CarController : Controller
    {
     private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {

            var result = _carService.GetAll(); // SuccessDataResult<List<Entity.Concerete.Brand>>
            if (result.Success)
            {
                return View(result.Data); // Sadece Data özelliğini gönderiyoruz
            }
            return View(new List<Car>());
        }
        public IActionResult Index2()
        {

            var result = _carService.GetAllCarsWithBrands(); // SuccessDataResult<List<Entity.Concerete.Brand>>
            if (result.Success)
            {
                return View(result.Data); // Sadece Data özelliğini gönderiyoruz
            }
            return View(new List<Car>());
        }
        public IActionResult CarList()
        {
            var result = _carService.GetAllCarsWithBrands(); // SuccessDataResult<List<Entity.Concerete.Brand>>
            if (result.Success)
            {
                return View(result.Data); // Sadece Data özelliğini gönderiyoruz
            }
            return View(new List<Car>());
        }

    }
}

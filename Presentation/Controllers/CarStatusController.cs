using Business.Abstract;
using Entity.Concerete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CarStatusController : Controller
    {
        private readonly ICarStatusService _carStatusSercive;

        public CarStatusController(ICarStatusService carStatusSercive)
        {
            _carStatusSercive = carStatusSercive;
        }

        public IActionResult Index()
        {

            var result =_carStatusSercive.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return View(new List<CarStatus>());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(CarStatus carStatus)
        {
           _carStatusSercive.Add(carStatus);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var result = _carStatusSercive.GetById(id);
            _carStatusSercive.Delete(result.Data);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var result = _carStatusSercive.GetById(id);
            return View(result.Data);
        }
        [HttpPost]
        public IActionResult Update(CarStatus carStatus)
        {
            _carStatusSercive.Update(carStatus);
            return RedirectToAction("Index");
        }
    }
}

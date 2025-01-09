using Business.Abstract;
using Entity.Concerete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Presentation.Controllers
{
    public class PriceController : Controller
    {
        private readonly IPriceService _priceService;
        private readonly ICarService _carService;//car sınıfını getirmek için

        public PriceController(IPriceService priceService, ICarService carService)
        {
            _priceService = priceService;
            _carService = carService;
        }

        public IActionResult Index()
        {
          var result =_priceService.GetPricesWithCars();
            if (result.Success)
            {
                return View(result.Data);
            }
            return View(new List<Price>());
        }
        public IActionResult Add()
        {
            // _carService.GetAllCarsWithBrands() çağrısının sonucunu al
            var result = _carService.GetAllCarsWithBrands();

            // Eğer işlem başarılıysa
            if (result.Success)
            {
                // Data üzerinden LINQ sorgusunu çalıştır
                List<SelectListItem> results = result.Data.Select(x => new SelectListItem
                {
                    Text = x.Brand.BrandName + " " + x.Model,
                    Value = x.CarId.ToString()
                }).ToList();

                ViewBag.v = results; // ViewBag'e ekle
            }
            else
            {
                // Hata durumunda boş bir liste döndür
                ViewBag.v = new List<SelectListItem>();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Add(Price price)
        {

            _priceService.Add(price);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var result = _priceService.GetById(id);
            _priceService.Delete(result.Data);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            // _carService.GetAllCarsWithBrands() çağrısının sonucunu al
            var result = _carService.GetAllCarsWithBrands();

            // Eğer işlem başarılıysa
            if (result.Success)
            {
                // Data üzerinden LINQ sorgusunu çalıştır
                List<SelectListItem> results = result.Data.Select(x => new SelectListItem
                {
                    Text = x.Brand.BrandName + " " + x.Model,
                    Value = x.CarId.ToString()
                }).ToList();

                ViewBag.v = results; // ViewBag'e ekle
            }
            else
            {
                // Hata durumunda boş bir liste döndür
                ViewBag.v = new List<SelectListItem>();
            }
            var priceResults = _priceService.GetById(id);
            return View(priceResults.Data);

        }
        [HttpPost]
        public IActionResult Update(Price price)
        {
            _priceService.Update(price);
            return RedirectToAction("Index");
        }
    }
}

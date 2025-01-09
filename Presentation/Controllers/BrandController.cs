using Business.Abstract;
using Core.Utulities.Results;
using Entity.Concerete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class BrandController : Controller
    {

        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var result = _brandService.GetAll(); // SuccessDataResult<List<Entity.Concerete.Brand>>
            if (result.Success)
            {
                return View(result.Data); // Sadece Data özelliğini gönderiyoruz
            }
            return View(new List<Brand>());
        }

       
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Brand brand)
        {
          
            _brandService.Add(brand);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var result=_brandService.GetById(id);
            _brandService.Delete(result.Data);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var result = _brandService.GetById(id);
            return View(result.Data);
        
        }
        [HttpPost]
        public IActionResult Update(Brand brand)
        {
            _brandService.Update(brand);
            return RedirectToAction("Index");
        }

    }
}

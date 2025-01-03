using Business.Abstract;
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
            return View(new List<Entity.Concerete.Brand>());
        }
    }
}

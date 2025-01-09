using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.ServiceComponent
{
    public class _HowItWorkComponentPartial : ViewComponent
    {
        private readonly IHowItWorkService _howItWorkService;

        public _HowItWorkComponentPartial(IHowItWorkService howItWorkService)
        {
            _howItWorkService = howItWorkService;
        }
        public IViewComponentResult Invoke()
        {
            var results = _howItWorkService.GetAll();
            if (results.Success)
            {
                return View(results.Data);
            }
            return View();
        }
    }
}

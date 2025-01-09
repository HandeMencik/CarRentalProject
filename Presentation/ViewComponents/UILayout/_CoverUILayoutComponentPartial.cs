using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.UILayout
{
    public class _CoverUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}


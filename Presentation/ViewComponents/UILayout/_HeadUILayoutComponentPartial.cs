using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.UILayout
{
    public class _HeadUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.UILayout
{
    public class _FooterUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.UILayout
{
    public class _ScriptUILayoutComponentPartial:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

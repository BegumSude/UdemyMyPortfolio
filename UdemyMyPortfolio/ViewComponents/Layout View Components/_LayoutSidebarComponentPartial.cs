using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.ViewComponents.Layout_View_Components
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.ViewComponents.Layout_View_Components
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

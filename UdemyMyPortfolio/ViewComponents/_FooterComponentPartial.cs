using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

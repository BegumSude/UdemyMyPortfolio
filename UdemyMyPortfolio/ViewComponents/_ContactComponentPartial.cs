using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.Context;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
           
            return View();
        }

    }
}

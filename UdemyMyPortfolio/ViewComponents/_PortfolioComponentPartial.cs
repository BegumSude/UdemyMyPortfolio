using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.Context;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}

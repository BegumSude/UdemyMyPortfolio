using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.Context;

namespace UdemyMyPortfolio.ViewComponents.Layout_View_Components
{
    public class _LayoutNavbarComponentPartial :ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}

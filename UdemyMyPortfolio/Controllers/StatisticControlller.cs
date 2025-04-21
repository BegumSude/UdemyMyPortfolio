using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using UdemyMyPortfolio.Context;

namespace UdemyMyPortfolio.Controllers
{
    public class StatisticControlller : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        { 
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.V3 = context.Messages.Where(x=>x.IsRead == false).Count();
            ViewBag.V3 = context.Messages.Where(x=>x.IsRead == true).Count();
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.Context;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.ProjectCount = context.Portfolios.Count();
            ViewBag.SkillCount = context.Skills.Count();
            ViewBag.TestimonialCount = context.Testimonials.Count();
            ViewBag.ExperienceCount = context.Experiences.Count();

            return View();
        }
    }
}

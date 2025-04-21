using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.Context;
using UdemyMyPortfolio.DAL.Entities;

namespace UdemyMyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public IActionResult ChangeReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ShowMessage(int id)
        {
            var value = context.Messages.Find(id);
            if (value == null)
            {
                return NotFound(); // Eğer id yoksa hata döner
            }
            return View(value);
        }


        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateMessage(Message message)
        {
            context.Messages.Update(message);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }


    }
}

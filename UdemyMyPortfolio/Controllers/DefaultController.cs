using Microsoft.AspNetCore.Mvc;
//single page application
//bu controller  backend'i tutucak
namespace UdemyMyPortfolio.Controllers
{
    public class DefaultController : Controller  //miras alıyoruz
    {
        public IActionResult Index() //IAction .net core ile gelişti, 
        {
            return View(); //razor view=.net core'da html içinde c# kullanmaya yarayan syntax
        }
    }
}

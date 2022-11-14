using Freelancer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Controllers
{
    public class HomeController : Controller
    {
        List<Portfolio> portfolios = new()
        {
            new Portfolio{Id=1,Title="Tasty Cake",Icon="fa-light fa-star-and-crescent",PhotoUrl="https://cdn-icons-png.flaticon.com/512/5965/5965249.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil,"}
        };
        About abouts = new()
        {
            Icon = "fa-light fa-star-and-crescent",
            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil"
        };
        public IActionResult Index()
        {
            ViewBag.Title = "Compar Academy";
            ViewBag.SubTitle = "Graphic Artist - Web Designer - Illustrator";
            ViewBag.Icon = "fa-light fa-star-and-crescent";
            ViewBag.PhotoUrl = "https://cdn-icons-png.flaticon.com/512/4481/4481273.png";
            ViewData["Portfolios"] = portfolios;
            ViewData["Abouts"] = abouts;
            return View();
        }
    }
}

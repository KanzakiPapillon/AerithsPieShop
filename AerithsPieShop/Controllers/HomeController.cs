using AerithsPieShop.Models;
using AerithsPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AerithsPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModels(piesOfTheWeek);
            return View(homeViewModel);
        }
    }
}

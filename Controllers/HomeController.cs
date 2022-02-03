using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllClothes _clothesRepository;

        public HomeController(IAllClothes clothesRepository)
        {
            _clothesRepository = clothesRepository;
        }

        public ViewResult Index()
        {
            var homeClothes = new HomeViewModel
            {
                favClothes = _clothesRepository.GetFavouriteClothes
            };

            return View(homeClothes);
        }
    }
}

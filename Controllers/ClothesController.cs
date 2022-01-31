using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class ClothesController : Controller
    {
        private readonly IAllClothes _allClothes;
        private readonly IClothesCategory _allCategories;

        public ClothesController(IAllClothes iAllClothes, IClothesCategory iClothesCategory)
        {
            _allClothes = iAllClothes;
            _allCategories = iClothesCategory;
        }

        public ViewResult ProductList()
        {
            ViewBag.Title = "Clothes page";
            ClothesProductListViewModel obj = new ClothesProductListViewModel();
            obj.allClothes = _allClothes.Clothes;
            obj.clothesCategory = "Products";
            return View(obj);
        }
    }
}

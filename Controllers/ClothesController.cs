using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

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

        [Route("Clothes/ProductList")]
        [Route("Clothes/ProductList/{category}")]
        public ViewResult ProductList(string category)
        {
            string _category = category;
            IEnumerable<Clothes> clothes = null;
            string currentCategory = null;

            if (string.IsNullOrEmpty(category))
            {
                clothes = _allClothes.Clothes.OrderBy(i => i.Id);
            }
            else
            {
                if(string.Equals("Outerwear", category, StringComparison.OrdinalIgnoreCase))
                {
                    clothes = _allClothes.Clothes.Where(i => i.Category.Name.Equals("Outerwear")).OrderBy(i => i.Id);
                }
                else if (string.Equals("Underwear", category, StringComparison.OrdinalIgnoreCase))
                {
                    clothes = _allClothes.Clothes.Where(i => i.Category.Name.Equals("Underwear")).OrderBy(i => i.Id);
                }
                else if (string.Equals("Shoes", category, StringComparison.OrdinalIgnoreCase))
                {
                    clothes = _allClothes.Clothes.Where(i => i.Category.Name.Equals("Shoes")).OrderBy(i => i.Id);
                }

                currentCategory = _category;
            }

            ViewBag.Title = "Clothes page";
            var clothesObj = new ClothesProductListViewModel
            {
                allClothes = clothes,
                clothesCategory = currentCategory
            };
            return View(clothesObj);
        }
    }
}

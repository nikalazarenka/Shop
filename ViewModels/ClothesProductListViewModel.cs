using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class ClothesProductListViewModel
    {
        public IEnumerable<Clothes> allClothes { get; set; }

        public string clothesCategory;
    }
}

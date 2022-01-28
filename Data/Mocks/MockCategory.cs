using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategory : IClothesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{Name ="Outerwear", Description = "Clothing worn over other clothes, especially outdoors."},
                    new Category{Name = "Underwear", Description = "Clothing worn under other clothes, typically next to the skin."}
                };
            }
        }
    }
}

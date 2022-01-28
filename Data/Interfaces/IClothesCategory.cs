using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    interface IClothesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

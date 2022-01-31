using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IClothesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

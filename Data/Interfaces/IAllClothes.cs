using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IAllClothes
    {
        IEnumerable<Clothes> Clothes { get; }
        IEnumerable<Clothes> GetFavouriteClothes { get; set; }
        Clothes getObjectClothes(int carId);
    }
}

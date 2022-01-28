using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockClothes : IAllClothes
    {
        private readonly IClothesCategory _clothesCategory = new MockCategory();
        public IEnumerable<Clothes> Clothes
        {
            get
            {
                return new List<Clothes>
                {
                    new Clothes
                    {
                        Name = "Coat",
                        Description = "An outer garment with sleeves, worn outdoors and typically extending below the hips.",
                        Image = "https://static.massimodutti.net/3/photos//2021/I/0/1/p/6465/648/802/6465648802_2_6_16.jpg?t=1634632704900",
                        Price = 200.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = _clothesCategory.AllCategories.First()
                    },
                    new Clothes
                    {
                        Name = "Bra",
                        Description = "An undergarment worn by women to support the breasts.",
                        Image = "https://www.victoriassecret.com/p/760x1013/tif/c6/0b/c60bf9848fe1424e8c0df264f7bba462/111993675D46_OM_F.jpg",
                        Price = 50.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = _clothesCategory.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Clothes> GetFavouriteClothes { get; set; }

        public Clothes getObjectClothes(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

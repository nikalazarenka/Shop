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
                        Description = "Gray-brown wool coat.",
                        Image = "/img/woolcoat.jpg",
                        Price = 22990.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = _clothesCategory.AllCategories.First()
                    },
                    new Clothes
                    {
                        Name = "Jacket",
                        Description = "Coated cotton parka with velvet collar",
                        Image = "/img/parka.jpg",
                        Price = 19900.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = _clothesCategory.AllCategories.First()
                    },
                    new Clothes
                    {
                        Name = "Down Jacket",
                        Description = "Double-breasted down jacket",
                        Image = "/img/downjacket.jpg",
                        Price = 16300.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = _clothesCategory.AllCategories.First()
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

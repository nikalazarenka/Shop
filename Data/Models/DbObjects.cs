using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Models;

namespace Shop.Data.Models
{
    public class DbObjects
    {
        public static void Initial(AppDbContext context)
        {
            if (!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Clothes.Any())
            {
                context.AddRange(
                    new Clothes
                    {
                        Name = "Coat",
                        Description = "Gray-brown wool coat.",
                        Image = "/img/woolcoat.jpg",
                        Price = 22990.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Outerwear"]
                    },
                    new Clothes
                    {
                        Name = "Jacket",
                        Description = "Coated cotton parka with velvet collar",
                        Image = "/img/parka.jpg",
                        Price = 19900.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Outerwear"]
                    },
                    new Clothes
                    {
                        Name = "Down Jacket",
                        Description = "Double-breasted down jacket",
                        Image = "/img/downjacket.jpg",
                        Price = 16300.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Outerwear"]
                    },
                    new Clothes
                    {
                        Name = "Sandals",
                        Description = "Heeled leather sandals with plaited straps",
                        Image = "/img/sandals.jpg",
                        Price = 6940.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Shoes"]
                    },
                    new Clothes
                    {
                        Name = "Boots",
                        Description = "Brown leather boots with super track sole",
                        Image = "/img/boots.jpg",
                        Price = 11650.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Shoes"]
                    },
                    new Clothes
                    {
                        Name = "Chelsea Boots",
                        Description = "Leather chelsea boots with track soles",
                        Image = "/img/chelseaboots.jpg",
                        Price = 11191.0M,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Shoes"]
                    }
                    );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var categoryList = new Category[]
                    {
                         new Category{Name ="Outerwear", Description = "Clothing worn over other clothes, especially outdoors."},
                         new Category{Name = "Underwear", Description = "Clothing worn under other clothes, typically next to the skin."},
                         new Category{Name = "Shoes", Description = "A covering for the foot, typically made of leather, having a sturdy sole and not reaching above the ankle."}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category cat in categoryList)
                    {
                        category.Add(cat.Name, cat);
                    }
                }

                return category;
            }
        }
    }
}

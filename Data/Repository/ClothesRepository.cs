using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class ClothesRepository : IAllClothes
    {
        private readonly AppDbContext appDbContext;
        public ClothesRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Clothes> Clothes => appDbContext.Clothes.Include(c => c.Category);

        public IEnumerable<Clothes> GetFavouriteClothes => appDbContext.Clothes.Where(p => p.IsFavourite).Include(c => c.Category);

        public Clothes getObjectClothes(int clothesId) => appDbContext.Clothes.FirstOrDefault(p => p.Id == clothesId);
    }
}

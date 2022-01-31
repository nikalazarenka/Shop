using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ClothesProductListViewModel
    {
        public IEnumerable<Clothes> allClothes { get; set; }

        public string clothesCategory;
    }
}

using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Clothes> favClothes { get; set; }

    }
}

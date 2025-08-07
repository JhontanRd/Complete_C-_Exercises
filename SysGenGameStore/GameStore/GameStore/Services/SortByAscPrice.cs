using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Services
{
    public sealed class SortByAscPrice : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            // throw new NotImplementedException();
            return x.Price.CompareTo(y.Price);
        }
    }
}

using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Services
{
    public sealed class SortByDescPrice : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            //throw new NotImplementedException();
            return y.Price.CompareTo(x.Price); // Invertendo a comparação para ordenar de forma decrescente
        }
    }
}

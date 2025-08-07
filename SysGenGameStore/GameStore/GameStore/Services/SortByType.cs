using GameStore.Entities;

namespace GameStore.Services
{
    public sealed class SortByType : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return x.GetType().Name.CompareTo(y.GetType().Name); // Compara os tipos dos produtos pelo nome da classe
        }
    }
}

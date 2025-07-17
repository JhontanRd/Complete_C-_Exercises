using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenProducts.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder msgPriceTag = new StringBuilder();
            msgPriceTag.Append($"{Name} ");
            msgPriceTag.Append($"{TotalPrice().ToString("C2", new CultureInfo("en-US"))} ");
            msgPriceTag.Append($"(Customs fee: {CustomsFee.ToString("C2", new CultureInfo("en-US"))})");
            return msgPriceTag.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}

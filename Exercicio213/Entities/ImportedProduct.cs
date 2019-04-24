using System.Globalization;
namespace Exercicio213.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomsFee = customFee;
        }


        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        override public string PriceTag()
        {
            return $"{Name} $"
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + $" (Custom fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
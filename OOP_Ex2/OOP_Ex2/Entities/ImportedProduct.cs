using System.Globalization;

namespace OOP_Ex2.Entities;

public class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    public ImportedProduct( string name, double price, double customsFee ) : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public override string PriceTag()
    {
        return $"{Name} -  $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee})";
    }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }
}
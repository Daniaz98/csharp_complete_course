using System.Globalization;

namespace OOP_Ex2.Entities;

public class UsedProduct : Product
{
    public DateOnly ManufactureDate { get; set; }

    public UsedProduct(DateOnly manufactureDate, string name, double price) : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }

    public override string PriceTag()
    {
        return $"Name: {Name} (used) - $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate})";
    }
}
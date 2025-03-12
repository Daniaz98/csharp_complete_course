namespace WorkingWithFiles.Entities;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public int TotalQ()
    {
        return Quantity * Price;
    }
}
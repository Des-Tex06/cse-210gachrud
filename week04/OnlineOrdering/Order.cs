public class Order
{
    Customer name;

    private List<Product> _products = new List<Product>();

    public void CalculateTotalCost()
    {
        
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine(name);
        Console.WriteLine(Product productID);
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine($"{name}");
        Console.WriteLine(Address DisplayAddress());
    }
}
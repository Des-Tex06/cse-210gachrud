public class Order
{
    Product productID;
    Customer name;
    private List<Product> _products = new List<Product>();
    Product ComputeProductCost;
    Address ReturnUSAResidence;
    Address address;

    public void CalculateTotalCost()
    {
        
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine(name);
        Console.WriteLine(productID);
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine(name);
        Console.WriteLine(address);
    }
}                                        
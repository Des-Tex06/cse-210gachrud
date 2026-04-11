public class Product
{
    private string _name = "";
    private string _productID = "";
    private double _price; 
    
    private int _productQuantity;

    public string GetProductName()
    {
        return _name;
    }
    public void SetProductName(string name)
    {
        _name = name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }
    public double GetProductPrice()
    {
        return _price;
    }
    public void SetProductPrice(double price)
    {
        _price = price;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public void SetProductQuantity(int productQuantity)
    {
        _productQuantity = productQuantity;
    }
    public void ComputeProductCost()
    {
        _price *= _productQuantity;
    }
}
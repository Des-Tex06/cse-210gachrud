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
    public string GetProductID()
    {
        return _productID;
    }
    public double GetProductPrice()
    {
        return _price;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }

    public void ComputeProductCost()
    {
        _price *= _productQuantity;
    }
}
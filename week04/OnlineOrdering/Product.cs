using System.Reflection;
using System.Runtime.CompilerServices;

class Product
{
    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;
    public Product(string name, string productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public Product(string name, string productID, float price)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = 1;
    }

    public float CalculateCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public int GetQuanity()
    {
        return _quantity;
    }
}
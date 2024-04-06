using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private double _quantity;

    public Product(string name, string productId, double price, double quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return  _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _productId;
    }
}
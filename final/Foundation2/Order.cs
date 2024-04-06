using System.Runtime.InteropServices;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double OrderTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.TotalCost();
        }

        total += ShippingCost();

        return Math.Round(total, 2);
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetName()}, Product ID [{p.GetId()}]");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine($"{_customer.GetAddress()}");
    }

    public double ShippingCost()
    {
        if (_customer.FromUSA() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}
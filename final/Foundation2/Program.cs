using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new();
        
        // Create Order 1
        Address a1 = new("1011 Deon Dr", "Pocatello", "ID", "United States of America");
        Customer c1 = new("Tristan Galloway", a1);
        Product p1_1 = new("CPU", "10", 159.99, 1);
        Product p1_2 = new("GPU", "11", 599.99, 1);
        Product p1_3 = new("RAM", "12", 50.99, 2);
        Order o1 = new(c1);
        o1.AddProduct(p1_1);
        o1.AddProduct(p1_2);
        o1.AddProduct(p1_3);

        // Create Order 2
        Address a2 = new("505 Yale Ave", "Rexburg", "ID", "United States of America");
        Customer c2 = new("Garon Galloway", a2);
        Product p2_1 = new("TV", "1", 799.99, 2);
        Product p2_2 = new("Gooogle Doorbell", "2", 230.99, 1);
        Order o2 = new(c2);
        o2.AddProduct(p2_1);
        o2.AddProduct(p2_2);

        Address a3 = new("123 Canada Drive", "Montreal", "Quebec", "Canada");
        Customer c3 = new("Garon Galloway", a3);
        Product p3_1 = new("Book of Mormon", "3", 5.99, 3);
        Product p3_2 = new("Bible", "4", 12.99, 1);
        Order o3 = new(c3);
        o3.AddProduct(p3_1);
        o3.AddProduct(p3_2); 

        // Add all orders to a list
        orders.Add(o1);
        orders.Add(o2);
        orders.Add(o3);

        Console.Clear();
        foreach (Order o in orders)
        {
            o.GetPackingLabel();
            o.GetShippingLabel();
            Console.WriteLine($"\nTotal Order Cost: ${o.OrderTotalCost()}\n");
        }
    }
}
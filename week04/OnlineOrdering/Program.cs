using System;

class Program
{
    static void Main(string[] args)
    {
        // CUSTOMER 1 - USA
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("USB Cable", "P001", 5.99, 3));
        order1.AddProduct(new Product("Laptop Stand", "P002", 29.90, 1));

        // CUSTOMER 2 - OUTSIDE USA
        Address address2 = new Address("Av. Julius Nyerere", "Maputo", "MP", "Mozambique");
        Customer customer2 = new Customer("Yuran Nhangumbe", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mouse Wireless", "P010", 15.50, 2));
        order2.AddProduct(new Product("Keyboard", "P011", 25.00, 1));
        order2.AddProduct(new Product("Headphones", "P012", 40.00, 1));

        // DISPLAY RESULTS
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine("-----------------------------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalPrice():0.00}");
    }
}
    
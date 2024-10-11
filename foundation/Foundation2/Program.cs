using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Don Alfaro St", "Tetuan", "Zamboanga City", "PH");
        Address address2 = new Address("San Jose road", "Baliwasan", "Zamboanga City", "USA");

        Customer customer1 = new Customer("Rap Bro", address1);
        Customer customer2 = new Customer("Kath Bro", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Dipstick", "0001", 280.00m, 2)); 
        order1.AddProduct(new Product("AC Condenser", "0002", 5499, 1));


        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone case", "0003", 159, 10));
        order2.AddProduct(new Product("Sophie Kinensela book", "0004", 300, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: {order1.CalculateTotalCost()}");

        Console.WriteLine();
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: {order2.CalculateTotalCost()}");
    }
}
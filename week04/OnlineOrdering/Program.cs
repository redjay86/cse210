using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Wireless Mouse", "123", (float)19.99);
        Product product2 = new Product("Mechanical Keyboard", "456", (float)89.99, 5);
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Jerry", address1);
        Order order1 = new Order([product1, product2], customer1);

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Cost: ${order1.CalculateCost()}");
        Console.WriteLine("---------------------------------------------");

        Product product3 = new Product("Facial Cleanser", "789", (float)14.99, 2);
        Product product4 = new Product("Moisturizing Cream", "101", (float)24.99);
        Address address2 = new Address("36 Jacarepagua", "Rio de Janeiro", "RJ", "BRA");
        Customer customer2 = new Customer("Samantha", address2);
        Order order2 = new Order([product3, product4], customer2);

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Cost: ${order2.CalculateCost()}");
        Console.WriteLine("---------------------------------------------");

    }
}
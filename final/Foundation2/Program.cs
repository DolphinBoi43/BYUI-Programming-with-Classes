using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Product: name | id | price (float 0.00) | amount (float 0.0)
        Address: string | city | state | country
        Customer: name | Address
        Order: Customer
        */
        // Create products
        Product product1 = new Product("Laptop", "P001", 1200.0f, 1.0f);
        Product product2 = new Product("Mouse", "P002", 20.0f, 3.0f);
        Product product3 = new Product("Paper", "P003", 2.20f, 12.0f);
        Product product4 = new Product("Printer", "P004", 300.0f, 1.0f);
        Product product5 = new Product("Swag", "P005", 49.99f, 1.5f);
        Product product6 = new Product("Mug", "P006", 12.0f, 3.0f);

        // Create addresses
        Address usaAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Address nonUsaAddress = new Address("456 Elm St", "Townsville", "NSW", "Australia");

        // Create customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer nonUsaCustomer = new Customer("Jane Doe", nonUsaAddress);

        // Create orders
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        
        // Print Order Details 
        Console.WriteLine($"{order1.ShippingLabel()}\n{order1.PackingLabel()}\nTotal - ${order1.FinalCost():0.00}\n");
        Console.WriteLine($"{order2.ShippingLabel()}\n{order2.PackingLabel()}\nTotal - ${order2.FinalCost():0.00}\n");
    }
}
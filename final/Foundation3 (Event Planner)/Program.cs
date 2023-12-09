using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Product: name | id | price (float .2f) | amount (int)
        Address: string | city | state | country
        Customer: name

        */
        // Create products
        Product product1 = new Product("Laptop", "P001", 1200.0, 2.0);
        Product product2 = new Product("Mouse", "P002", 20.0, 3.0);

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

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product1);
    }
}
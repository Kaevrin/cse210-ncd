using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 1st St", "Johnsonville", "wyoming", "United States");
        Customer customer1 = new Customer("John Freeman", address1);
        var product1 = new Product("Laptop", "P001", 1000, 1);
        var product2 = new Product("Mouse", "P002", 50, 2);
        var products1 = new List<Product> { product1, product2 };

        Order order1 = new Order(products1, customer1);
        order1.PrintShippingLabel();

        Address address2 = new Address("5678 2nd Ave", "Smithville", "Nevada", "United States");
        Customer customer2 = new Customer("Emily Harris", address2);
        var product3 = new Product("Smartphone", "P003", 800, 1);
        var product4 = new Product("Keyboard", "P004", 30, 3);
        var products2 = new List<Product> { product3, product4 };

        Order order2 = new Order(products2, customer2);
        order2.PrintShippingLabel();
    }
}
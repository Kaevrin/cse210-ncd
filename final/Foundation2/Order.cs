class Order {
    private Customer _customer;
    private List<Product> _items;


    public Order(List<Product> products, Customer customer) {
        _customer = customer;
        _items = products;
    }

    public void PrintShippingLabel() {
        Console.WriteLine(_customer.GetCustomer());
        foreach (var item in _items)
        {
            Console.WriteLine(item.GetProduct());
        };
        if (_customer.IsDomestic()) {
            Console.WriteLine("Shipping fee: $5");
        }
        else {
            Console.WriteLine("Shipping fee: $35");
        }
        Console.WriteLine($"Total: ${GetOrderTotal()}");
    }
        public int GetOrderTotal()
    {
        int total = 0;
        foreach (var product in _items)
        {
            total += product.GetTotal();
        }
        return total;
    }
}
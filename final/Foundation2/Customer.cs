class Customer {
    private string _lastName;
    private string _firstName;
    private Address _address;

    public Customer(string name, Address address) {
        string[] parts = name.Split(' ');
        _firstName = parts[0];
        _lastName = parts[1];
        _address = address;
    }
    public string GetCustomer() {
        string customer = $"{_lastName}, {_firstName}";
        return customer;
    }
    public bool IsDomestic() {
        return _address.IsDomestic();
    }
}
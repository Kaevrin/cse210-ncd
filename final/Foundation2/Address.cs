class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isDomestic;

    public Address(string street, string city, string state, string country) {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

        if (_country != "United States") {
            _isDomestic = false;
        }
    }

    public string GetAddress() {
        string address = $"{_street}\n{_city}, {_state}\n{_country}";
        return address;
    }
    public bool IsDomestic() {
        return _isDomestic;
    }
}
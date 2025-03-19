using System.Numerics;

class Product {
    private string _name;
    private string _id;
    private int _price;
    private int _count;


    public Product(string name, string id, int price, int count) {
        _name = name;
        _id = id;
        _price = price;
        _count = count;
    }
        public Product(string name, string id, int price) {
        _name = name;
        _id = id;
        _price = price;
        _count = 1;
    }

    public int GetTotal() {
        int total = _price * _count;
        return total;
    }
    public int GetPrice() {
        return _price;
    }
    public string GetProduct() {
        return $"{_name} (ID: {_id}) - Qty: {_count}, Unit Price: ${_price}";
    }
    }
class Outdoor : Event {
    private string _weather;

    public Outdoor(string title, string description, DateTime date, string address, string weather) : base(title, description, date, address) {
        _weather = weather;
        _specificInfo = $"Expected weather: {_weather}";
    }
}
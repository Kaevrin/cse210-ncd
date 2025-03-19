class Lecture : Event {
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, string address, string speaker, int capacity) : base(title, description, date, address) {
        _speaker = speaker;
        _capacity = capacity;
        _specificInfo = $"Speaker: {_speaker}\nLimit: {_capacity} listeners";
    }
}
class Reception : Event {
    private string _link;

    public Reception(string title, string description, DateTime date, string address, string link) : base(title, description, date, address) {
        _link = link;
        _specificInfo = $"Registration Link:\n{_link}";
    }
}
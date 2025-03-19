class Event {
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _specificInfo;


    public Event(string title, string description, DateTime date, string address) {
        _title = title;
        _description = description;
        _date = date.ToString("MM-dd--yyyy");
        _time = date.ToString("HH:mm");
        _address = address;
    }

    public string GetStandard() {
        return $"\n{_title} - {_description}\n{_date} @ {_time}\n{_address}";
    }
    public string GetFull() {
        return $"\n{_title} - {_description}\n{_date} @ {_time}\n{_address}\n{_specificInfo}";
    }
    public string GetShort() {
        return $"\n{this.GetType().Name} - {_title}\n{_date}";
    }
}
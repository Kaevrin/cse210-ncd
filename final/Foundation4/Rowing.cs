class Rowing : Activity {
    private double _speed;

    public Rowing(DateTime date, int minutes, double speed) : base(date, minutes) {
        _speed = speed;
    }

    public override string GetSummary() {
        double distance = _speed * (_minutes / 60.0);
        double pace = _minutes / distance;
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name}({_minutes} min)- Distance {distance} miles, Speed {_speed} mph, Pace {pace} min per mile";
    }
}
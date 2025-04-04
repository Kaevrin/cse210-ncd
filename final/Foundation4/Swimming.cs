class Swimming : Activity {
    private double _laps;

    public Swimming(DateTime date, int minutes, double laps) : base(date, minutes) {
        _laps = laps;
    }
    public override string GetSummary() {
        double distance = _laps * 50 / 1000 * 0.62;
        double speed = distance / _minutes * 60;
        double pace = _minutes / distance;
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name}({_minutes} min)- Distance {distance} miles, Speed {speed} mph, Pace {pace} min per mile";
    }
}
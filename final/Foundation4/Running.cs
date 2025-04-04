class Running : Activity {
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes) {
        _distance = distance;
    }
    public override string GetSummary() {
        double speed = _distance/_minutes * 60;
        double pace = _minutes/_distance;
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name}({_minutes} min)- Distance {_distance} miles, Speed {speed} mph, Pace {pace} min per mile";
    }
}
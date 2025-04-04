class Tempcode : Activity {

//using biking as a template//
private int _speed;

    public Tempcode(DateTime date, int minutes, int speed) : base(date, minutes) {
        _speed = speed;
    }

    public override string GetSummary() {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_minutes} min)- Distance {GetDistance(_speed, _minutes)} miles, Speed {_speed} mph, Pace {GetPace(GetDistance(_speed, _minutes))} min per mile.";
    }
}
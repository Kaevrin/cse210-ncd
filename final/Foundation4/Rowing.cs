class Rowing : Activity {
    private double _pace;

    public Rowing(DateTime date, int minutes, double pace) : base(date, minutes) {
        _pace = pace;
    }

    protected override double GetDistance()
    {
        return _minutes / GetPace();
    }
    protected override double GetPace()
    {
        return _pace; 
    }
}
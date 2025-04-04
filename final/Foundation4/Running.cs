class Running : Activity {
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes) {
        _distance = distance;
    }
    protected override double GetDistance()
    {
        return _distance;
    }

}
class Swimming : Activity {
    private double _laps;

    public Swimming(DateTime date, int minutes, double laps) : base(date, minutes) {
        _laps = laps;
    }
    protected override double GetDistance()
    {
         return _laps * 50 / 1000 * 0.62;
    }
}
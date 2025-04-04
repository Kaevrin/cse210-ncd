class Biking : Activity {
    private double _speed;

    public Biking(DateTime date, int minutes, double speed) : base(date, minutes) {
        _speed = speed;
    }

        protected override double GetSpeed()
    {
        return _speed;
    }

}
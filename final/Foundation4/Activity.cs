class Activity {
    protected DateTime _date;
    protected int _minutes;


    public Activity(DateTime date, int minutes) {
        _date = date;
        _minutes = minutes;
    }


    protected virtual string GetSumary() {
        return "Error, no override given.";
    }
}
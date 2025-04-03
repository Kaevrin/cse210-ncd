using System.Xml;

class Activity {
    protected DateTime _date;
    protected int _minutes;


    public Activity(DateTime date, int minutes) {
        _date = date;
        _minutes = minutes;
    }


    public virtual string GetSummary() {
        return "Error, no override given.";
    }
    protected virtual double GetDistance(double speed, double time) {
        double output = speed * (time/60);
        return output;
    }
    protected virtual double GetSpeed(double pace) {
        double output = _minutes / pace;
        return output;
    }
    protected virtual double GetPace(double distance) {
        double output = _minutes / distance;
        return output;
    }
}

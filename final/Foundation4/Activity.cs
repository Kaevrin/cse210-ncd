using System.Xml;

class Activity {
    protected DateTime _date;
    protected int _minutes;


    public Activity(DateTime date, int minutes) {
        _date = date;
        _minutes = minutes;
    }


    public virtual string GetSummary() {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name}({_minutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
    protected virtual double GetDistance() {
        return GetSpeed() * (_minutes / 60.0);
    }
    protected virtual double GetSpeed() {
         return GetDistance() / (_minutes / 60.0);
    }
    protected virtual double GetPace() {
         return _minutes / GetDistance(); 
    }
}

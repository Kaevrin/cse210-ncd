class Activity {
    string _startingMessage;
    int _time;
    string _name;

    protected Activity(int duration) {
        SetTime(duration);
    }
    protected void ShowSpinner(int duration) {

    }
    protected string Showintro() {
        return "bingus";
    }
    protected void SetTime(int duration) {
        _time = duration;
    }
    protected void ShowCountdown(int seconds) {

    }
    protected void ShowEnding() {
        
    }

}
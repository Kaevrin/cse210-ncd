using System.Diagnostics;

class Activity {
    string _startingMessage;
    protected int _time;
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
        _time = duration * 1000;
    }
    protected void ShowCountdown(int seconds) {

    }
    protected void ShowEnding() {
        
    }

}
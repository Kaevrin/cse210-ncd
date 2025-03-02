using System.Diagnostics;
using System.Security.Cryptography;

class Activity {
    protected string _startingMessage;
    private string _endingMessage;
    protected int _time;
    private string _className;
    protected int _currentLine = Console.CursorTop;
    protected string _activityInfo;

    protected Activity(int duration) {
        SetTime(duration);
        _className = this.GetType().Name;
        _startingMessage =  "Welcome to the " + _className +  " activity. This activity will " + _activityInfo +"\nGet ready...";
        _endingMessage = "Good job!";
    }
    protected async Task ShowSpinner(int duration) {
        Stopwatch stopwatch = Stopwatch.StartNew();
        string [] spinner = { "/", "-", "\\", "|"};
        int i = 0;
        while(stopwatch.ElapsedMilliseconds <= duration) {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);

            Console.Write(spinner[i]);
            i = (i + 1) % spinner.Length;
            await Task.Delay(200);
        }
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("");
    }
    protected void ShowIntro() {
        Console.WriteLine(_startingMessage);
    }
    protected void SetTime(int duration) {
        _time = duration * 1000;
    }
    protected async Task ShowEnding() {
        Console.WriteLine(_endingMessage);
        await ShowSpinner(5000);
        Console.WriteLine("Thank you for using the " + _className + " activity.");
        await ShowSpinner(5000);
    }

    protected void ClearLine()
{
    Console.SetCursorPosition(0, Console.CursorTop -1);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, Console.CursorTop);
}

}
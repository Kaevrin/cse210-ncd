using System.Diagnostics;


class Breathing : Activity {
    private int _breathInterval = 4000;
    public Breathing(int time) : base(time) {
        _activityInfo = "help you relax through controlled and slow breathing. Clear your mind and focus only on your breathing.";
        Console.Clear();
        ShowIntro();

    }
    private async Task BreatherLoop() {
        Console.WriteLine("Breath in.");
        await Countdown(4000);
        Console.WriteLine("Breath out.");
        await Countdown(4000);
    }

    private async Task Countdown(int duration) {
        Stopwatch stopwatch = Stopwatch.StartNew();
        int secondsRemaining = duration/1000;
        while(secondsRemaining > 0) {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(secondsRemaining);
            await Task.Delay(1000);
            secondsRemaining--;
        }

        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("");
    }

    public async Task Run() {
        await ShowSpinner(5000);
        Stopwatch stopwatch = Stopwatch.StartNew();
        while(true) {
            long remainingTime = _time - stopwatch.ElapsedMilliseconds;
            if (remainingTime < 1.9 * _breathInterval) break;
            await BreatherLoop();

        }
        Console.Write(new string(' ', Console.WindowWidth));
        await ShowEnding();
    }

}
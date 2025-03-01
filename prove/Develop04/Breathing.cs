using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Breathing : Activity {
    private int _breathInterval = 1000;
    public Breathing(string message, int time) : base(time) {
        Console.WriteLine(message);
    }
    private async Task BreatherLoop() {
        Console.WriteLine("Breath in.");
        await Task.Delay(_breathInterval);
        Console.WriteLine("Breath out.");
        await Task.Delay(_breathInterval);
    }
    public async Task Run() {
        Stopwatch stopwatch = Stopwatch.StartNew();
        while(true) {
            long remainingTime = _time - stopwatch.ElapsedMilliseconds;
            if (remainingTime < 1.9 * _breathInterval) break;
            Console.WriteLine("stopwatch: " + stopwatch);
            await BreatherLoop();

        }
    }

}
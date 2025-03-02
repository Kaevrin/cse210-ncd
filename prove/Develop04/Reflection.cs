using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
class Reflection : Activity {
    private List<string> _prompts = new List<string> {
            "List things that made you smile this week, no matter how small.",
            "Write down everything you’re feeling in this moment without filtering or judgment.",
            "Describe a place—real or imaginary—that feels completely peaceful to you.",
            "List things you love about yourself today.",
            "Jot down any worries or stresses on your mind, then write a kind or comforting response to each."
    };
    private string _userReply;

    public Reflection(int time) : base(time) {
        Console.Clear();
        ShowIntro();

        GetRandomPrompt();
    }
    private void GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index]; 
        Console.WriteLine(randomPrompt);
    }

    public void GetReply(string reply) {
        _userReply = reply;
    }

    public async Task Run() {
        await ShowSpinner(5000);
        Stopwatch stopwatch = Stopwatch.StartNew();
        while(stopwatch.ElapsedMilliseconds < _time) {
            if (Console.KeyAvailable) {
                Task<string> inputTask = Task.Run(() => Console.ReadLine());
                Task delayTask = Task.Delay((int)(_time - stopwatch.ElapsedMilliseconds));
                if (await Task.WhenAny(inputTask, delayTask) == inputTask) {
                    _userReply = inputTask.Result;
                }
                break;
            }
        }
        Console.ReadKey(true);
        await ShowEnding();
        }
            
}
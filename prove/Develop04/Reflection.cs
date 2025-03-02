using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
class Reflection : Activity {
    private List<string> _prompts = new List<string> {
            "What is one intention you want to set for today?",
            "What is one kind thing you can say to yourself right now?",
            "Take three deep breaths. How does your body feel in this moment?",
            "What is one thing you can release today to bring more peace into your life?",
            "Describe your surroundings using all five senses. What do you notice?",
            "What is one small win you had today, no matter how minor?",
            "Close your eyes for a moment. What sensations do you feel in different parts of your body?",
            "What emotions are you experiencing right now? How can you acknowledge them without judgment?"
    };
    private string _userReply;

    public Reflection(int time) : base(time) {
        _activityInfo = "help you ponder on your life and what you can be doing to improve.";
        Console.Clear();
        ShowIntro();

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
        GetRandomPrompt();
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
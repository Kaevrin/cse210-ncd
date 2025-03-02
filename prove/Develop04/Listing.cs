
using System.Diagnostics;
class Listing : Activity {
    private List<string> _prompts = new List<string> {
    "Take a moment to reflect on the small things that brought you peace today. Write down everything that comes to mind.",
    "Think of the times you’ve felt stressed recently. How did you respond? What are other mindful ways you could respond?",
    "Write down any messages of kindness or encouragement you'd give your past self, with compassion and understanding.",
    "What are the simple things in your life that fill you with gratitude? List as many as you can in this moment.",
    "Pause and reflect on what inner peace means to you. Write down everything that helps you feel centered and calm.",
    "Take a moment to think about things, places, or activities that bring you comfort. Write down everything you can think of.",
    "When have you felt truly grounded and present? Write down those moments of mindfulness and connection.",
    "What are the qualities in the people around you that you appreciate most? Reflect and write them down.",
    "What goals bring you peace when you think of them? Reflect on what feels right for you at this moment and write it down.",
    "In what moments do you feel most connected to the present? Write down the simple things that help you feel in the now."
};
    private List<string> _replies = new List<string> {};

    public Listing(int time) : base(time) {
        _activityInfo = "help you think of positive things in your life";
        Console.Clear();
        ShowIntro();

    }

    private void GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index]; 
        Console.WriteLine(randomPrompt);
    }

    public async Task Run() {
        await ShowSpinner(5000);
        GetRandomPrompt();
        Stopwatch stopwatch = Stopwatch.StartNew();
        var cancellationTokenSource = new CancellationTokenSource();
        var token = cancellationTokenSource.Token;
        while(stopwatch.ElapsedMilliseconds < _time) {            
            Task<string> inputTask = Task.Run(() => Console.ReadLine());
            Task delayTask = Task.Delay((int)(_time - stopwatch.ElapsedMilliseconds));
            if (await Task.WhenAny(inputTask, delayTask) == inputTask) {
                _replies.Add(inputTask.Result);
                }
            else  {
                Console.WriteLine("");
                cancellationTokenSource.Cancel();
                break;
            }
        }
        ClearLine();
        await ShowEnding();     
    }
}

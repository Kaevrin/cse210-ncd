public class Prompt
{
    private static List<string> journalPrompts = new List<string>
    {
        "What is one small moment from today that made you smile?",
        "If you could give your past self one piece of advice, what would it be?",
        "Describe a place that makes you feel at peace and why it’s special to you.",
        "What is one challenge you faced recently, and how did you handle it?",
        "Write about a time when you felt truly confident in yourself.",
        "What is something you’ve been procrastinating on, and why?",
        "If you could master any new skill instantly, what would it be and why?",
        "Describe a recent conversation that stuck with you and why it mattered.",
        "What are three things you’re grateful for today?",
        "How do you hope to grow as a person in the next year?"
    };

    public static string GetPrompt()
    {
        Random random = new Random();
        return journalPrompts[random.Next(journalPrompts.Count)];
    }
}   
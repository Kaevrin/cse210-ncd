using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Biking biking = new Biking(new DateTime(2024, 3, 31), 40, 30);
        activities.Add(biking);
        Running running = new Running(new DateTime(2024, 10, 23), 60, 10);
        activities.Add(running);
        Swimming swimming = new Swimming(new DateTime(2023, 6, 1), 10, 50);
        activities.Add(swimming);
        foreach (Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "FrostGiant";
        job1._jobTitle = "Rock Climber";
        job1._startYear=1997;
        job1._endYear=2006;
        Job job2 = new Job();
        job2._company = "FreeJam";
        job2._jobTitle = "Design Jammer";
        job2._startYear =2007;
        job2._endYear = 2017;
        Resume resume1 = new Resume();
        resume1._name = "John Johnson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
        
    }
}
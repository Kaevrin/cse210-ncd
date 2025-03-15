using System;

class Program
{
    static void Main(string[] args)
    {
        Outdoor outdoor = new Outdoor("Potluck","A community potluck to celebrate the holiday.", new DateTime(2025, 3, 14, 15, 30, 0), "1234 Park St.", "cloudy");
        Console.WriteLine(outdoor.GetStandard());
        Console.WriteLine(outdoor.GetFull());
        Console.WriteLine(outdoor.GetShort());
        Reception reception = new Reception("High School Reunion","20th year reception for class of 2005", new DateTime(2025, 6, 27, 17, 0, 0),"7542 Highland Way", "trustworthylink.link");
        Console.WriteLine(reception.GetStandard());
        Console.WriteLine(reception.GetFull());
        Console.WriteLine(reception.GetShort());
        Lecture lecture = new Lecture("Influences of AI on Modern Day Society","Industry veteran talks about his experiences with AI in the workforce and across industries.", new DateTime(2025, 8, 3, 19, 30, 0),"326 University Ave.", "Frank Sinatra", 50);
        Console.WriteLine(lecture.GetStandard());
        Console.WriteLine(lecture.GetFull());
        Console.WriteLine(lecture.GetShort());
    }
}
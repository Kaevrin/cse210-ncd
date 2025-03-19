using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video> {
            new Video("The Wonders of Space", "Dr. Emily Carter", 542),
            new Video("C# Tips and Tricks", "Jane Developer", 780),
            new Video("How to Bake Sourdough Bread", "Chef Antonio", 1200),
            new Video("Top 10 Hiking Trails", "Outdoor Explorer", 655)
        };

        videos[0].AddComment("AstroFan42", "This blew my mind! So fascinating.");
        videos[0].AddComment("SpaceLover", "I've always wanted to know more about black holes. Thanks!");
        videos[0].AddComment("StarSeeker", "Great explanation, very easy to understand.");

        videos[1].AddComment("CodeMaster99", "Wow, the LINQ tip was a game changer!");
        videos[1].AddComment("DevGuy", "Can you do a deeper dive on async/await next time?");
        videos[1].AddComment("CodeQueen", "Super helpful, thanks a ton!");
        videos[1].AddComment("DebugGuru", "I didn’t know about the null-coalescing operator. Mind blown!");


        videos[2].AddComment("BreadLover", "Mine came out perfect!");
        videos[2].AddComment("HomeBaker123", "Can you explain more about proofing times?");
        videos[2].AddComment("YeastBeast", "Best sourdough tutorial!");

        videos[3].AddComment("TrailBlazer", "Adding these to my bucket list!");
        videos[3].AddComment("HikeNSeek", "The views at #3 are absolutely stunning.");
        videos[3].AddComment("AdventureGal", "Love how you included hidden gems!");
        videos[3].AddComment("Wanderer", "Time to dust off my boots!");

        foreach (var video in videos) {
            video.Display();
            Console.WriteLine();
        }
    }
}
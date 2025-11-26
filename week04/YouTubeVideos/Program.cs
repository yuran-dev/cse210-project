using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the list of videos
        List<Video> videos = new List<Video>();

        // ------------------ VIDEO 1 ------------------
        Video video1 = new Video(
            "The Dawn of Civilization",
            "Yuran",
            540);

        video1.AddComment(new Comment("Igor", "Amazing explanation about early societies!"));
        video1.AddComment(new Comment("Ava", "Humanity came a long way since those days."));
        video1.AddComment(new Comment("Ria", "Great video, very educational!"));

        videos.Add(video1);

        // ------------------ VIDEO 2 ------------------
        Video video2 = new Video(
            "The Rise and Fall of Ancient Empires",
            "Yuwenga",
            680);

        video2.AddComment(new Comment("Igor", "The Roman Empire part was really interesting!"));
        video2.AddComment(new Comment("Ava", "History always repeats itself."));
        video2.AddComment(new Comment("Ria", "Loved the visuals!"));

        videos.Add(video2);

        // ------------------ VIDEO 3 ------------------
        Video video3 = new Video(
            "Humanity in the Modern Age",
            "Wenga",
            720);

        video3.AddComment(new Comment("Igor", "Technology changed everything."));
        video3.AddComment(new Comment("Ava", "Very deep message about society today."));
        video3.AddComment(new Comment("Ria", "We truly live in a unique time."));

        videos.Add(video3);

        // ------------------ DISPLAY OUTPUT ------------------
        foreach (Video v in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"  - {c.CommenterName}: {c.Text}");
            }

            Console.WriteLine();
        }
    }
}

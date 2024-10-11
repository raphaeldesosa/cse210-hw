using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to bake bread", "Rap Bros", 300);
        video1.addComment(new Comments("Ryan", "So easy to make"));
        video1.addComment(new Comments("Aeron", "I still dont get it"));
        videos.Add(video1);

        Video video2 = new Video("Python Tutorial", "Tech with me", 1200);
        video2.addComment(new Comments("Kath", "Thank you for this!"));
        video2.addComment(new Comments("Kevin", "You are going way to fast"));
        videos.Add(video2);

        Video video3 = new Video("Java Script Tutorial", "JS team", 600);
        video3.addComment(new Comments("Gary", "this is still very confusing"));
        video3.addComment(new Comments("Doc", "Why isnt this working for me??"));
        videos.Add(video3);

        foreach(var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetnumberofComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                comment.DisplayComment();
            }
            Console.WriteLine();
        }
    }
}
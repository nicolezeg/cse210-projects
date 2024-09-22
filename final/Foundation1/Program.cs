using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("Video 1", "Author 1", 300);
        video1.AddComment(new Comment("Commenter 1", "This is a great video!"));
        video1.AddComment(new Comment("Commenter 2", "I agree!"));
        video1.AddComment(new Comment("Commenter 3", "Not bad."));

        var video2 = new Video("Video 2", "Author 2", 400);
        video2.AddComment(new Comment("Commenter 4", "This video is okay."));
        video2.AddComment(new Comment("Commenter 5", "I like it!"));
        video2.AddComment(new Comment("Commenter 6", "Not my favorite."));

        var video3 = new Video("Video 3", "Author 3", 500);
        video3.AddComment(new Comment("Commenter 7", "This video is amazing!"));
        video3.AddComment(new Comment("Commenter 8", "I know, right?"));
        video3.AddComment(new Comment("Commenter 9", "Best video ever!"));

        var videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}
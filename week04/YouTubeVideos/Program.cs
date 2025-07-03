using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];
        videos.Add(new Video("How to Cook Pasta", "ChefJohn", 300));
        videos.Add(new Video("Learn C# in 10 Minutes", "CodeAcademy", 600));
        videos.Add(new Video("Top 10 Travel Destinations", "Wanderlust", 480));
        videos.Add(new Video("Beginner Yoga Routine", "YogaWithRexquando", 900));

        videos[0].AddComment(new Comment("Chris", "Great recipe! My family loved it."));
        videos[0].AddComment(new Comment("Daniel", "Easy to follow instructions."));
        videos[0].AddComment(new Comment("Everett", "Can you do a gluten-free version?"));

        videos[1].AddComment(new Comment("Dane", "Very helpful for beginners."));
        videos[1].AddComment(new Comment("Cole", "Clear explanations, thanks!"));
        videos[1].AddComment(new Comment("Isaac", "I'd rather use JavaScript"));

        videos[2].AddComment(new Comment("Grace", "I want to visit all these places!"));
        videos[2].AddComment(new Comment("Heidi", "Beautiful footage."));
        videos[2].AddComment(new Comment("Cannon", "Add more destinations next time!"));

        videos[3].AddComment(new Comment("Owen", "Perfect for my morning routine."));
        videos[3].AddComment(new Comment("Kade", "Loved the calming voice."));
        videos[3].AddComment(new Comment("Rex", "This is the type of yoga I like to see."));
        videos[3].AddComment(new Comment("Raul", "Such a big fan!"));

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Comment> comments1 = new List<Comment>();
        comments1.Add(new Comment("Sean", "Wow, the scenery is incredible! I've always wanted to visit Cusco, and this video just moved it higher on my travel list."));
        comments1.Add(new Comment("Emily", "The colors, the mountains, and the history all look amazing. Thanks for sharing these beautiful spots!"));
        comments1.Add(new Comment("Samir", "The footage is stunning! Could you make another short showing local food and cultural experiences in Cusco?"));
        comments1.Add(new Comment("Monica", "Great video! Could you share some tips about the best time of year to visit and how difficult the hike is?"));

        Video video1 = new Video("Machu Picchu (Cuzco) History, Secrets & Views", "James Anderson", 751, comments1);

        List<Comment> comments2 = new List<Comment>();
        comments2.Add(new Comment("Mark", "These pancakes look so fluffy! I'm definitely trying this recipe for breakfast tomorrow."));
        comments2.Add(new Comment("Lisa", "I love how simple the ingredients are. Perfect recipe for when you want something quick and delicious."));
        comments2.Add(new Comment("Andres", "Just made these and they turned out amazing. Thanks for sharing such an easy recipe!"));
        comments2.Add(new Comment("Juana", "I've tested dozens of pancake recipes, and this is definitely one of the best. Crispy edges, soft center, perfect texture!"));

        Video video2 = new Video("The Only Pancake Recipe You'll Ever Need", "Jessica Brown", 493, comments2);

        List<Comment> comments3 = new List<Comment>();
        comments3.Add(new Comment("Carlos", "This was exactly the fix I needed! Saved me a call to the plumber."));
        comments3.Add(new Comment("Rafael", "Great explanation. The step-by-step demonstration made it really easy to follow."));
        comments3.Add(new Comment("Jorge", "I had a small leak under my sink and this video helped me understand what to check first."));
        comments3.Add(new Comment("James", "Does this method work for copper pipes as well, or is it only for PVC? Any advice would be appreciated."));

        Video video3 = new Video("Fix a Leaky Pipe in Minutes", "Matthew White", 346, comments3);

        List<Video> videosAll = new List<Video>();
        videosAll.Add(video1);
        videosAll.Add(video2);
        videosAll.Add(video3);

        foreach (Video video in videosAll)
        {
            Console.WriteLine(video.GetFullInfoVideo());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetDisplayComment());
            }
        }
    }
}
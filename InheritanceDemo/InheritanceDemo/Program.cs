using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Merry Christmas", "Sidney Shafer", true);
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Got some new shoes ;)", "Sidney Shafer",
                "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Sunset in Florida.", "Sidney Shafer", "https://videos.com/sunset.mp3", 50, true);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class VideoPost : Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;


        protected string VideoURL { get; set; }

        protected int Length { get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            //properties and GetNextID() method are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Video has started!");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
       
        }
        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Video stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - " +
                $"{this.Length}s - by {this.SendByUsername}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Post
    {
        private static int currentPostId;

        //properties
        //protected --> can only be used by this class and any deriving (child) class
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //Default Constructor
        //If a derived (child) class does not invoke a base-class
        //constructor explicity, the default constructor is called implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Sidney Shafer";
        }

        // Instance constructor that has three parameters
        public Post(string title, string sendByUsername, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        //Generate an ID
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        //edit the post
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //virtual method override of the ToString() method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }

    }
}

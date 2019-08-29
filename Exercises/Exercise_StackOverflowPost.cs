using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Exercises
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfCreation { get; private set; }
        public int CurrentVoteValue { get;  private set; }

        public Post(string Title, string Description, DateTime TimeOfCreation)
        {
            this.Title = Title;
            this.Description = Description;
            this.TimeOfCreation = TimeOfCreation;
        }

        public void Upvote()
        {
            this.CurrentVoteValue++;
        }

        public void Downvote()
        {
            this.CurrentVoteValue--;
        }
    }
}

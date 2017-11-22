using System;

namespace Exercises_S2_L15_2
{
    public class Post
    {
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Created = DateTime.Now;
        }

        private int _votes;

        public string Title { get; }
        public string Description { get; set; }
        public DateTime Created { get; }

        public int Votes => _votes;

        public int UpVote()
        {
            _votes += 1;
            return _votes;
        }

        public int DownVote()
        {
            _votes -= 1;
            return _votes;
        }
    }
}
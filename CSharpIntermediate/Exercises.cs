using System;

namespace Exercises
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _counting;

        public Stopwatch()
        {
            _counting = false;
        }

        public void Start()
        {
            if (_counting)
            {
                throw new InvalidOperationException("The stopwatch is running!");
            }

            _startTime = DateTime.Now;
            _counting = true;
        }

        public void Stop()
        {
            if (!_counting)
            {
                throw new InvalidOperationException("The Stopwatch is not running!");
            }

            _endTime = DateTime.Now;
            _counting = false;
        }

        public TimeSpan GetDuration()
        {
            return _endTime - _startTime;
        }
    }

    public class Post
    {
        private DateTime _createDateTime;

        public string Title { get; set; }
        public string Description { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            _createDateTime = DateTime.Now;
        }

        public void UpVoting()
        {
            UpVote++;
        }

        public void DownVoting()
        {
            DownVote++;
        }
    }
}
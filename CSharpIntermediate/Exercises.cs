using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpIntermediate
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

    public class Stack
    {
        private List<object> _items;

        public Stack()
        {
            _items = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Push item cannot be null");
            }
            _items.Add(obj);
        }

        public object Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Stack is null");
            }

            var item = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return item;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }

    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            Timeout = TimeSpan.FromMinutes(5);
        }

        public abstract void Open();
        public abstract void Close();
    }

    public class SqlConnection :DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            
        }

        public override void Open()
        {
            Console.WriteLine("Open SqlConnection");
        }

        public override void Close()
        {
            Console.WriteLine("Close SqlConnection");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            
        }

        public override void Open()
        {
            Console.WriteLine("Open OracleConnection");
        }

        public override void Close()
        {
            Console.WriteLine("Close OracleConnection");
        }
    }

    public class DbCommand
    {
        public DbConnection DbConnection { get; set; }
        public string Command { get; set; }

        public DbCommand(DbConnection dbConnection, string command)
        {
            DbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }

        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("Execute {0} command", Command);
            DbConnection.Close();
        }
    }
}



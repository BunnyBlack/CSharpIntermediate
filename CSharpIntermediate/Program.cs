using System;
using System.Threading;
using Exercises;

namespace CSharpIntermediate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        private static void Exercise16_2()
        {
            var post = new Post("Hello World", "Hello World");
            post.UpVoting();
            post.UpVoting();
            post.UpVoting();
            post.UpVoting();
            post.UpVoting();
            post.DownVoting();

            Console.WriteLine("Title: {0} Description: {1} up-vote: {2} down-vote: {3}", post.Title, post.Description,
                post.UpVote.ToString(), post.DownVote.ToString());
        }

        private static void Exercise16_1()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(3000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.GetDuration().ToString());
        }

        public static void IndexerMethod()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
        }

        public static void PropertiesMethod()
        {
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);
        }

        public static void GetSetMethod()
        {
            // var person = new Person();
            // person.SetBirthdate(new DateTime(1982, 1, 1));
            // Console.WriteLine(person.GetBirthdate());
        }

        public static void ReadonlyMethod()
        {
            var customer = new Customer(1);
            Console.WriteLine(customer.Orders.Count);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }

        public static void TryParseMethod()
        {
            var number = 0;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed!");
            }
        }

        public static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] {1, 2, 3, 4, 5}));
        }

        public static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected exception has occured!");
            }
        }

        // public static void ObjectInitializerMethod()
        // {
        //     var person = new Person()
        //     {
        //         Name = "John"
        //     };
        //     person.Introduce("Mosh");
        // }
        //

        // public static void ClassCreateMethod()
        // {
        //     var person = new Person();
        //     person.Name = "John";
        //     person.Introduce("Mosh");
        //
        //     var p = Person.Parse("John");
        //     p.Introduce("Mosh");
        // }
    }
}
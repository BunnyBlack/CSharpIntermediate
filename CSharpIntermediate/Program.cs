using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace CSharpIntermediate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var command = new DbCommand(new SqlConnection("Test1"), "Update");
            command.Execute();
            Console.WriteLine();
            command.DbConnection = new OracleConnection("Test2");
            command.Command = "Add";
            command.Execute();
        }

        private static void Exercise32_1()
        {
            var sqlConnection = new SqlConnection("Test1");
            var oracleConnection = new OracleConnection("Test2");
            sqlConnection.Open();
            sqlConnection.Close();

            oracleConnection.Open();
            oracleConnection.Close();
        }

        private static void AbstractMethod()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }

        private static void Exercise27()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        private static void BoxingMethod()
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();
            anotherList.Add(1);
            var names = new List<string>();
            names.Add("1");
        }

        private static void UpcastingMethod()
        {
            var text = new Text();
            PresentationObject obj = text; // 并未自动进行类型转换 而是指向了同一个变量
            text.Width = 200;
            obj.Width = 100;
            Console.WriteLine(text.Width);
            obj = text as PresentationObject;
            obj.Width = 200;
            Console.WriteLine(text.Width);
            // var reader = new StreamReader(new MemoryStream());
            

            var anotherList = new List<PresentationObject>();

            PresentationObject shape = new Text();
        }

        private static void ConstructorAndInheritanceMethod()
        {
            var car = new Car("XYZ123");
        }

        private static void CompositionMethod()
        {
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }

        private static void InheritanceMethod()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
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
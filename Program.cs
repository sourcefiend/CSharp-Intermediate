using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("John");
            //person.Introduce("Mosh");

            var customer = new Customer(1, "John");

            var order = new Order();
            customer.Orders.Add(order);

            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }
            


            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");

            var customer_two = new CustomerTwo(1);

            customer_two.Orders.Add(new OrderTwo());
            customer_two.Orders.Add(new OrderTwo());

            customer_two.Promote();

            //Console.WriteLine(customer_two.Orders.Count);

            var person_two = new PersonTwo();
            person_two.SetBirthdate(new DateTime(1982, 1, 1));
            //Console.WriteLine(person_two.GetBirthdate());

            var person_three = new PersonThree(new DateTime(1982, 1, 1));
            //Console.WriteLine(person_three.Age);

            var cookie = new HttpCookie();
            cookie["name"] = "mosh";
            //Console.WriteLine(cookie["name"]);

            var stopwatch = new Stopwatch();

            //while (true)
            //{
            //    Console.WriteLine("Type in any key to exit or hit ENTER to start a new session");
            //    var input = Console.ReadLine();
            //    if (input == "")
            //    {
            //        stopwatch.Start();

            //        Console.WriteLine("Stopwatch started. Press ENTER to stop.");
            //        Console.ReadLine();
            //        stopwatch.Stop();
            //    }
            //    else
            //        break;
            //}

            var post_one = new Exercises.Post("Problem with Python", "I can't log in to my application with Python", DateTime.Now);

            post_one.Upvote();
            post_one.Upvote();
            post_one.Downvote();

            Console.WriteLine(post_one.CurrentVoteValue);

            post_one.Downvote();
            post_one.Downvote();

            Console.WriteLine(post_one.CurrentVoteValue);

            //var text = new Text();
            //text.Width = 100;
            //text.Copy();

            var dbMigrator = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

            //var client = new Amazon.Client();

            var car = new Car("XYZ1234");

            //StreamReader reader = new StreamReader(new MemoryStream());

            Shape shape = new ShapeText();
            ShapeText text = (ShapeText)shape;

            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();

            var names = new List<string>();

            var stack = new Classes.Exercises.Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
 
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            var circle = new CircleShape();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            // This is the database exercise
            Console.WriteLine("\n");

            var database = new OracleConnection("SQL connection string");
            var command = new DbCommand(database, "This is my test string");

            command.Execute();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 6, 7, 9 }));
        }

        static void UsePoints()
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
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
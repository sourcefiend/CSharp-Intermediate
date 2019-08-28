using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
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

            Console.WriteLine(customer_two.Orders.Count);

            var person_two = new PersonTwo();
            person_two.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person_two.GetBirthdate());


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
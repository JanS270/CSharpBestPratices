
// Tutorial youtube: Top 10 C# Best Practices(plus bonuses)    by Tim Corey

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace ConsoleUI
{
    class Program
    {
        private static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            SetUpSampleData();

            GreetAllThePeople();

            Console.ReadLine();
        }

        private static void StringDemoMethod()
        {
            String s = "";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine(DateTime.Now.ToLongDateString());

            for (int i = 0; i < 1000000; i++)
            {
                //s = s + "Hi "; //  Operacja wymaga zbyt wiele czasu
                sb.Append("Hi "); // Dziala natychmiastowo :)
            }

            Console.WriteLine(DateTime.Now.ToLongDateString());
        }

        private static void SetUpSampleData()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm" });
            people.Add(new Person { FirstName = "Jill", LastName = "Jones" });
        }

        private static void GreetAllThePeople()
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            }
        }
    }
}


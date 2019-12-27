using Extensions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Gent", "London", "Las Vegas", "Hyderabad" };
            IEnumerable<string> query = cities.Filter((item) => item.StartsWith("L"));
            foreach(var city in query)
            {
                Console.WriteLine(city);
                Thread.Sleep(2000);
            }
        } 
    }
}

namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter<T> (this IEnumerable<T> input, FilterDelegate<T> predicate)
        {
            foreach(var item in input)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
            
    }

    public delegate bool FilterDelegate<T>(T item);
}
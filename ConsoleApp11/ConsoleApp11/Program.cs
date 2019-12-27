using System;
using System.Threading;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> Square = (x) => x * x;
            Func<int, int, int> Add = (x, y) => (x + y);
            Action<int> Write = x=> Console.WriteLine(x);
            Write(Square(Add(5,2)));
            
            Thread.Sleep(1000);
        }
    }
}
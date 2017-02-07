using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Checker checker = new Checker();
            while (true)
            { 
            Console.WriteLine("Type 3 numbers after each other. I'll see if the match the patterns of a triangle.");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            Console.WriteLine("The result is: " + checker.TriangleChecker(a, b, c));
            }
        }
    }
}

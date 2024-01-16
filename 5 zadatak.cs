using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi cijeli broji i decimalni broji:");
            string input = Console.ReadLine();

            string[] broj = input.Split(' ');

            int x = int.Parse(broj[0]);
            double y = double.Parse(broj[1]);

            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.ReadLine();
        }
    }
}

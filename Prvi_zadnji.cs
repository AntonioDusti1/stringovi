using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prva_zadnja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi riječ");
            string riječ= Console.ReadLine();
            string[] recenica = riječ.Split(" ");
            string Prvarijec = recenica[0];
            string zadnjarijec = recenica[recenica.Length - 1];

            Console.WriteLine("Prva riječ: " + Prvarijec);
            Console.WriteLine("Zadnja riječ: " + zadnjarijec);
        }
    }
}

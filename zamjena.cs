using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razmak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi recenicu");
            string input = Console.ReadLine();
            string razmakString = input.Replace(" ","_");
            Console.WriteLine("Zamjena recenicu:" + razmakString);
            Console.ReadLine();
        }
    }
}

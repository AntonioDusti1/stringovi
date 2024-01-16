using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispis_slova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi rečenicu");
            string input = Console.ReadLine();
            string sVeliki = input.ToUpper();
            Console.WriteLine("sVeliki:" + sVeliki);
            string sMali = input.ToLower();
            Console.WriteLine("sMali:" + sMali);
            string sPrvatri = input.Substring(0, 3);
            Console.WriteLine("sPrvaTri:" + sPrvatri);
            string sZadnjiPet = input.Substring(input.Length - 5);
            Console.WriteLine("sZadnjiPet:" + sZadnjiPet);
            string s8_11 = input.Substring(7,4 );
            Console.WriteLine("s8_11:" + s8_11);
            Console.ReadLine();
        }
    }
}

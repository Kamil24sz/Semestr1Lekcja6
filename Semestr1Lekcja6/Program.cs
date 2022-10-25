using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1Lekcja6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSTRUKCJA WARUNKOWA (IF)

            if (10 == 11)
            {
                //wykonuje się jeśli prawda
                Console.WriteLine("Wykonuję pierwsze działanie w IF'ie");
                Console.WriteLine("Wykonuję drugie działanie w IF'ie");
            }
            else
            {
                //wykonuje się jeśli fałsz
                Console.WriteLine("Napis wypisze się jeśli jest fałsz");
            }

            Console.WriteLine("Poza IF'em");

            Console.ReadLine();
        }
    }
}

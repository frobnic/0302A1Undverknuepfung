using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302A1Undverknuepfung
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Bitte geben Sie eine zahl zwischen 10 und 100 ein: ");
            n = int.Parse(Console.ReadLine());

            if (n > 10 && n < 10)
                Console.WriteLine("rüschtüsch");
            else
                Console.WriteLine("falsch");
        }
    }
}

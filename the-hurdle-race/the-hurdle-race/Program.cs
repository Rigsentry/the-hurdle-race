using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_hurdle_race
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>() { 1, 6, 3, 5, 2 };
            Console.WriteLine(hurdleRace(4, a));

            var b = new List<int>() { 2, 5, 4, 5, 2 };
            Console.WriteLine(hurdleRace(7, b));

            Console.ReadKey();
        }

        public static int hurdleRace(int k, List<int> height)
        {
            int doses = 0;
            int higherHurdle = 0;
            foreach (int hurdle in height)
            {
                higherHurdle = higherHurdle < hurdle ? hurdle : higherHurdle;
            }
            doses = higherHurdle - k;
            return doses > 0 ? doses : 0;
        }
    }
}

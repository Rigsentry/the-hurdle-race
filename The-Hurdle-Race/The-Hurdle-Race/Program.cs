using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Hurdle_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> heights = new List<int> { 1, 6, 3, 5, 2 };
            int k = 4;
            Console.WriteLine("Max Doses Required : " + CalculateDosesRequired(k, heights));

            List<int> heights2 = new List<int> { 2, 5, 4, 5, 2 };
            int k2 = 7;

            Console.WriteLine("Max Doses Required : " + CalculateDosesRequired(k2, heights2));

            Console.ReadLine();
        }
        static int CalculateDosesRequired(int maxJumpHeight, List<int> hurdleHeights)
        {
            int maxHurdleHeight = hurdleHeights.Max();
            int dosesRequired = maxJumpHeight >= maxHurdleHeight ? 0 : maxHurdleHeight - maxJumpHeight;
            return dosesRequired;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)

        {

            int n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            var min = int.MaxValue;
            

            for (int i = 0; i < n; i++)
            {
                var numx = int.Parse(Console.ReadLine());
                var numy = int.Parse(Console.ReadLine());
                var sum = numx + numy;

               
                if (sum < min) { min = sum; }

                if (sum > max) { max = sum; }
                if (max == min) { Console.WriteLine("Yes, value = " + max); }
                else { Console.WriteLine("No, maxdiff = " + Math.Abs(max - min)); }

            }
        }
    }
}